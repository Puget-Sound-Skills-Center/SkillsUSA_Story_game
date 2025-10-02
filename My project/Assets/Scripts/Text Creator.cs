using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextCreator : MonoBehaviour
{











    public static TMPro.TMP_Text viewText;
    public static bool runTextPrint;
    public static int CharCount;
    [SerializeField] string transferext;
    [SerializeField] int internalcount;





    private void Update()
    {
        internalcount = CharCount;
        CharCount = GetComponent<TMPro.TMP_Text>().text.Length;
        if (runTextPrint == true)
        {
            runTextPrint = false;
            viewText = GetComponent<TMPro.TMP_Text>();
            transferext = viewText.text;
            viewText.text = "";
            StartCoroutine(RollText());
        }
    }
    IEnumerator RollText()
    {
        foreach (char c in transferext)
        {
            viewText.text += c;
            yield return new WaitForSeconds(0.03f);
        }
    }

}


//Start is called before the first frame
