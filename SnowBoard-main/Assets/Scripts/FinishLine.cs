using UnityEngine;
using UnityEngine.SceneManagement;


public class FinishLine : MonoBehaviour
{
    
    [SerializeField] float loadDelay = 1f;  
    [SerializeField] ParticleSystem finishEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("FinishLine Triggered by: " + other.name);
     
        if (other.tag == "Player")
        {

            finishEffect.Play();

            GetComponent<AudioSource>().Play();

            if (ScoreManager.instance == null)
            {
                Debug.LogError(" ScoreManager.instance is NULL!");
            }
            else
            {
                ScoreManager.instance.SaveFinalScore();
                Debug.Log(" Final Score Saved: " + ScoreManager.finalScore);
            }



            ScoreManager.instance.SaveHighScore();

            Invoke("ReloadScene", loadDelay);
        }
    }

    void ReloadScene()
    {

        SceneManager.LoadScene("Game Over");
    }
}
