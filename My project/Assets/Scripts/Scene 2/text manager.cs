using UnityEngine;
using TMPro;
using System.Collections;

public class TextDisplayManager : MonoBehaviour
{
    public static TextDisplayManager Instance;
    public TMP_Text outputText;
    public float typeSpeed = 0.02f;

    private Coroutine typingCoroutine;
    private bool isTyping = false;
    private string currentMessage;

    private void Awake()
    {
        // Safe singleton
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void ShowMessage(string msg)
    {
        if (isTyping)
        {
            SkipTyping();
            return;
        }

        currentMessage = msg;

        if (typingCoroutine != null)
            StopCoroutine(typingCoroutine);

        typingCoroutine = StartCoroutine(Typewriter(msg));
    }

    private IEnumerator Typewriter(string msg)
    {
        isTyping = true;
        outputText.text = "";

        foreach (char c in msg)
        {
            outputText.text += c;
            yield return new WaitForSeconds(typeSpeed);
        }

        isTyping = false;
    }

    private void SkipTyping()
    {
        if (!isTyping) return;

        outputText.text = currentMessage;
        isTyping = false;

        if (typingCoroutine != null)
            StopCoroutine(typingCoroutine);
    }
}
