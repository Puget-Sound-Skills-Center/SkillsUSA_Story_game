using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Script1 : MonoBehaviour
{

    public GameObject Fadein;
    public GameObject Mark;
    public GameObject Emily;
    public GameObject TextBox;
    public GameObject speaktext;
    public GameObject Name;

    //[SerializeField] AudioSource
    //[SerializeField] AudioSource 

    [SerializeField] string textToSpeak;
    [SerializeField] int CurrentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject maintextObject;

    void Update()
    {
        textLength = TextCreator.CharCount;
    }

    private void Start()
    {
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter()
    {
        yield return new WaitForSeconds(1);
        Fadein.SetActive(false);
        Mark.SetActive(true);
        yield return new WaitForSeconds(1);
        //where text will go
        textToSpeak = "";
        Name.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        TextBox.SetActive(true);
        Name.SetActive(true);
        CurrentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        print("pre wait");
        yield return new WaitForSeconds(0.05f);
       // yield return new WaitForSeconds(1);
        //yield return new WaitUntil(() => TextCreator.CharCount == CurrentTextLength);
       // yield return new WaitForSeconds(0.05f);
       // print("post wait");
        maintextObject.SetActive(true);
        speaktext.SetActive(true);
        yield return new WaitForSeconds(2);
        Emily.SetActive(true);


    }
}