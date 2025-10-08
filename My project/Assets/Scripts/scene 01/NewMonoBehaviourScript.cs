using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public GameObject Fadein;
    public GameObject Mark;
    public GameObject Emily;
    public GameObject TextBox;

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

    void Start()
    {
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter()
    {
        yield return new WaitForSeconds(2);
        Fadein.SetActive(false);
        Mark.SetActive(true);
        yield return new WaitForSeconds(2);
        //where text will go
        //TextBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        CurrentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => TextCreator.CharCount == CurrentTextLength);
        yield return new WaitForSeconds(0.05f);
        maintextObject.SetActive(true);
        textToSpeak = "hi";
        TextBox.SetActive(true);
        yield return new WaitForSeconds(2);
        Emily.SetActive(true);


    }
}