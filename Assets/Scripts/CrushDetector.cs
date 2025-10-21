
using UnityEngine;
using UnityEngine.SceneManagement; 


public class CrushDetector : MonoBehaviour
{
  
    [SerializeField] float loadDelay = 0.5f;  
    [SerializeField] ParticleSystem crushEffect;
    [SerializeField] AudioClip crushSFX;
     
    bool hasCrushed = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground" && !hasCrushed)
        {
            PlayerController player = FindAnyObjectByType<PlayerController>();

            if (player != null && player.isInvincible)
            {
                Debug.Log("🛡️ Player is invincible. No crush triggered.");
                return;
            }

            hasCrushed = true;
            player.DisableControls();
            crushEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crushSFX);
            Invoke("ReloadScene", loadDelay);
        }
    }

    void ReloadScene()
   {
        
        SceneManager.LoadScene("Game Over"); 
    }
}
