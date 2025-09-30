using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public GameObject Fadein;
    public GameObject Mark;
    public GameObject Emily;

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
        yield return new WaitForSeconds(2);
        Emily.SetActive(true);

    }
}
