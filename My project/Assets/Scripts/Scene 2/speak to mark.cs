using UnityEngine;

public class ClickRawImageToChangeText : MonoBehaviour
{
    public string customMessage;

    public void OnClick()
    {
        UpdateTexts();
    }

    public void SetCustomMessage(string msg)
    {
        customMessage = msg;
    }

    public void UpdateTexts()
    {
        Debug.Log(customMessage);
        // update UI text here
    }
}

