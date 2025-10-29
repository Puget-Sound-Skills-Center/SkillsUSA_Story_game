using System.Collections;
using UnityEngine;
using TMPro;

public class TypewriterText : MonoBehaviour
{
    [Header("Text Settings")]
    public TextMeshProUGUI viewText; // Assign in Inspector
    [TextArea(5, 20)] public string fullText; // The main text to display
    public float timePerChar = 0.03f; // Typing speed
    public string introLine = ""; // Optional intro text before the main text
    public float introDelay = 1f; // Delay before typing the main text

    [Header("Control Flags")]
    public static bool runTextPrint = false; // Trigger text typing from other scripts
    public static int CharCount; // Optional: track characters typed

    private bool skip = false; // Spacebar skip flag

    private void Start()
    {
        if (viewText == null)
        {
            viewText = GetComponent<TextMeshProUGUI>();
        }

        // Save the original text if needed
        if (string.IsNullOrEmpty(fullText))
            fullText = viewText.text;

        // Clear text before starting
        viewText.text = "";

        if (runTextPrint)
        {
            StartCoroutine(RollText());
        }
    }

    private void Update()
    {
        // Spacebar sets skip flag
        if (Input.GetKeyDown(KeyCode.Space))
            skip = true;

        // Track current character count
        CharCount = viewText.text.Length;
    }

    public IEnumerator RollText()
    {
        // Optional intro line
        if (!string.IsNullOrEmpty(introLine))
        {
            viewText.text = introLine;
            yield return new WaitForSeconds(introDelay);
        }

        // Clear text before typing main text
        viewText.text = "";

        for (int i = 0; i < fullText.Length; i++)
        {
            if (skip)
            {
                viewText.text = fullText; // Show all text instantly
                skip = false;
                break;
            }

            viewText.text = fullText.Substring(0, i + 1);
            yield return new WaitForSeconds(timePerChar);
        }
    }

    // Optional public method to trigger typing from another script
    public void StartTyping()
    {
        StartCoroutine(RollText());
    }
}
