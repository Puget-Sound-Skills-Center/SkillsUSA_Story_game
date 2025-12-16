using UnityEngine;

public class TextController : MonoBehaviour
{
    public ClickRawImageToChangeText[] clickScripts;

    void Start()
    {
        // Example: set unique messages for each clickable object
        clickScripts[0].SetCustomMessage("Hey! I'm Mark, how are you?");
        clickScripts[1].SetCustomMessage("You clicked the Shield!");
        clickScripts[2].SetCustomMessage("Hi! I'm Emily, welcome to the school!");
    }
}
