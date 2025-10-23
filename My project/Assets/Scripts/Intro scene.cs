using System.Collections;
using UnityEngine;

public class PlayAnimationOnceWithDelay : MonoBehaviour
{
    public Animator animator;      // Assign in Inspector
    public string triggerName;     // The Animator trigger (e.g. "Play")
    public float startDelay = 2;  // How long to wait before first play

    private bool hasPlayed = false;

    void Start()
    {
        StartCoroutine(StartAnimationAfterDelay());
    }

    IEnumerator StartAnimationAfterDelay()
    {
        yield return new WaitForSeconds(startDelay);

        if (!hasPlayed)
        {
            animator.SetTrigger("Play");
            hasPlayed = true;
        }
    }
}
