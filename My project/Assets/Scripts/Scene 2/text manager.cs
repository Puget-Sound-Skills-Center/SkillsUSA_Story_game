using UnityEngine;
using TMPro;
using System.Collections;

public class TextDisplayManager : MonoBehaviour
{
    public static TextDisplayManager Instance;
    public TMP_Text outputText;  // Assign in Inspector
    public float typeSpeed = 0.02f;

    private Coroutine typingCoroutine;

    private void Awake()
    {
        Instance = this;
    }
    private bool isTyping = false;
    private string currentMessage;

    public void ShowMessage(string msg)
    {
        // If already typing, skip instantly
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

        // Instantly show full message
        outputText.text = currentMessage;
        isTyping = false;

        if (typingCoroutine != null)
            StopCoroutine(typingCoroutine);
    }
}
