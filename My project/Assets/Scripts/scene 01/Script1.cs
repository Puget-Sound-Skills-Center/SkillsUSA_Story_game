using System.Collections;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    public Animator animator;      // Assign in Inspector
    public string triggerName = "Play"; // The Animator trigger
    public KeyCode keyToPress = KeyCode.Space; // Which key to wait for

    private bool hasPlayed = false;

    public GameObject Fadein;
    public GameObject Mark;
    public GameObject Emily;
    public GameObject TextBox;
    public GameObject speaktext;
    public GameObject Name;
    public GameObject introtext;
    public GameObject hinttext;

    //[SerializeField] AudioSource
    //[SerializeField] AudioSource 

    [SerializeField] string textToSpeak;
    [SerializeField] int CurrentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject maintextObject;

    void Update()
    {
        textLength = TypewriterText.CharCount; // <- changed from TextCreator
    }

    private void Start()
    {
        StartCoroutine(EventStarter());
    }

    IEnumerator WaitForButtonPress(KeyCode keyToPress)
    {
        Debug.Log($"Waiting for {keyToPress} to be pressed...");

        // Wait until the specified key is pressed
        while (!Input.GetKeyDown(keyToPress))
            yield return null;

        Debug.Log($"{keyToPress} was pressed!"); 
        if (!hasPlayed)
        {
            animator.SetTrigger(triggerName);
            hasPlayed = true;
            Debug.Log("Animation triggered!");
        }

    }


    IEnumerator EventStarter()
    {
        Mark.SetActive(true);
        Emily.SetActive(true);
        yield return StartCoroutine(WaitForButtonPress(KeyCode.Space));
        introtext.SetActive(false);
        hinttext.SetActive(false);
        yield return new WaitForSeconds(3);
        Fadein.SetActive(false);
        //where text will go
        yield return new WaitForSeconds(2);
        textToSpeak = "";
        Name.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        TextBox.SetActive(true);
        Name.SetActive(true);
        CurrentTextLength = textToSpeak.Length;
        TypewriterText.runTextPrint = true; // <- changed from TextCreator 
        maintextObject.SetActive(true);
        speaktext.SetActive(true);
        yield return new WaitForSeconds(2);
    }
}
