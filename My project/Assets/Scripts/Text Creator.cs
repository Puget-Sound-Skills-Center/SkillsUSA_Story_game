/*using System.Collections;
using UnityEngine;
using TMPro;

public class TextCreator : MonoBehaviour
{
    public static TMP_Text viewText;
    public static bool runTextPrint;
    public static int CharCount;

    [SerializeField] private string transferext;
    [SerializeField] private int internalcount;

    private void Start()
    {
        viewText = GetComponent<TMP_Text>();
        transferext = viewText.text;     // Save the original text
        viewText.text = "";              // Clear before typing

        if (runTextPrint)
            StartCoroutine(RollText());
    }

    private void Update()
    {
        internalcount = CharCount;
        CharCount = viewText.text.Length;
    }

    private IEnumerator RollText()
    {
        // Optional: intro line before typing begins
        viewText.text = "It's your first day, who would you like to speak to?\n\n";
        yield return new WaitForSeconds(1f);

        foreach (char c in transferext)
        {
            viewText.text += c;
            yield return new WaitForSeconds(0.03f); 
        }
    }
}
*/


//Start is called before the first frame