using UnityEngine;
using TMPro;

public class ChangeUIText : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro; // Assign in the Inspector

    public void ChangeText(string newText)
    {
        if (textMeshPro != null)
        {
            textMeshPro.text = newText;
        }
    }
}
