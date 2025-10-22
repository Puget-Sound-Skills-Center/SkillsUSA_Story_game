using UnityEngine;
using System.Collections;
using TMPro; // Important for TextMeshPro

public class TypewriterEffect : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro; // Assign your TextMeshProUGUI object in the Inspector
    public string fullText;
    public float timePerChar = 0.05f;

    void Start()
    {
        StartCoroutine(TypeWriter(fullText, timePerChar));
    }

    IEnumerator TypeWriter(string text, float waitTime)
    {
        textMeshPro.text = ""; // Clear the text initially
        for (int i = 0; i < text.Length; i++)
        {
            textMeshPro.text = text.Substring(0, i + 1); // Add one character at a time
            yield return new WaitForSeconds(waitTime);
        }
    }
}