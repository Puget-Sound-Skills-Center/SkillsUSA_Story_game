 using UnityEngine;

public class TextController : MonoBehaviour
{
    public ClickRawImageToChangeText clickScript; // Assign in Inspector or find it via code

    void Start()
    {
        // Example: Set a new custom message
        if (clickScript != null)
        {
            clickScript.SetCustomMessage("This was changed from another script!");

            // Trigger the same effect as if the user clicked the image
            clickScript.UpdateTexts();
        }
    }
}
