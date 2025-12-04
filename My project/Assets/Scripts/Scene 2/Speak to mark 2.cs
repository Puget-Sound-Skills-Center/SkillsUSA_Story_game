using UnityEngine;

public class TextController : MonoBehaviour
{
    public ClickRawImageToChangeText[] clickScripts;

    void Start()
    {
        // Example: set unique messages for each clickable object
        clickScripts[0].SetCustomMessage("You clicked the Sword!");
        clickScripts[1].SetCustomMessage("You clicked the Shield!");
        clickScripts[2].SetCustomMessage("You clicked the Potion!");
    }
}
