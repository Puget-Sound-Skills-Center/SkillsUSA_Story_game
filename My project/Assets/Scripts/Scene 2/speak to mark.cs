using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ClickRawImageToChangeText : MonoBehaviour, IPointerClickHandler
{
    [Header("Main text that shows the object's name")]
    public TextMeshProUGUI targetText; // Assign in Inspector

    [Header("Speak text (custom message)")]
    public TextMeshProUGUI speaktext; // Assign the TMP object named "speaktext" here
    [TextArea]
    public string customMessage = "Default custom message"; // Editable both in Inspector and Visual Studio

    private RawImage rawImage;

    void Start()
    {
        rawImage = GetComponent<RawImage>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        UpdateTexts();
    }

    // ✅ This public method lets you call the same logic from another script
    public void UpdateTexts()
    {
        if (targetText != null)
        {
            targetText.text = gameObject.name;
        }

        if (speaktext != null)
        {
            speaktext.text = customMessage;
        }
    }

    // Optional: Allows external scripts to change the custom message at runtime
    public void SetCustomMessage(string newMessage)
    {
        customMessage = newMessage;
        if (speaktext != null)
        {
            speaktext.text = newMessage;
        }
    }
}
