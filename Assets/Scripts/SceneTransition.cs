using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneTransition : MonoBehaviour
{
    public string SceneToLoad;
    public Animator animator;
    public PlayerMovement playerMovement;
    public Animator playerAnimator; 
    public Animator deurAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Optional: check if the player triggered the transition
        {
            StartCoroutine(FadeOutAndLoadScene());
            playerMovement.enabled = false;
            playerAnimator.enabled = false;
            print("trigger entered");
        }
    }

    IEnumerator FadeOutAndLoadScene()
    {
        // Trigger the fade-out animation
        deurAnimator.SetTrigger("TriggerOpen");
        animator.SetTrigger("Start");
        

        // Wait until the fade-out animation is complete
        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);

        // Load the new scene
        animator.SetTrigger("End");
        SceneManager.LoadScene(SceneToLoad);
        playerMovement.enabled = true;
        playerAnimator.enabled = true;
        

        // Optionally, trigger the fade-in animation (if the new scene uses the same animator)
        // animator.SetTrigger("FadeIn");
    }
}
