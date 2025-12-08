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
        Debug.Log("Clicked: " + customMessage);

        if (TextDisplayManager.Instance != null)
        {
            TextDisplayManager.Instance.ShowMessage(customMessage);
        }
        else
        {
            Debug.LogError("TextDisplayManager.Instance is NULL!");
        }
    }
}

