using UnityEngine;

public class ScoreItem : MonoBehaviour
{
    [SerializeField] int scoreValue = 100;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("✅ Item collected");
            ScoreManager.instance.AddScore(scoreValue);

            // 🔊 Phát âm thanh tại vị trí item
            AudioSource.PlayClipAtPoint(audioSource.clip, transform.position);

            // ❌ Huỷ item ngay lập tức
            Destroy(gameObject);
        }
    }
}
