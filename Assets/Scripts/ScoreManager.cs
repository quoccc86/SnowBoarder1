using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    //public TextMeshProUGUI scoreText;
    private int currentScore = 0;
    public static int finalScore = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log(" ScoreManager Awake in scene: " + SceneManager.GetActiveScene().name);
        }
        else
        {
            Debug.LogWarning(" Duplicate ScoreManager destroyed in scene: " + SceneManager.GetActiveScene().name);
            Destroy(gameObject);
        }
    }




    public void AddScore(int amount)
    {
        currentScore += amount;
        // Không cập nhật UI ở đây nữa
    }

    public void ResetScore()
    {
        currentScore = 0;
    }


    public int GetScore()
    {
        return currentScore;
    }
    public void SaveFinalScore()
    {
        finalScore = currentScore;
    }
    public void SaveHighScore()
    {
        int oldHighScore = PlayerPrefs.GetInt("HighScore", 0);
        if (currentScore > oldHighScore)
        {
            PlayerPrefs.SetInt("HighScore", currentScore);
            PlayerPrefs.Save();
        }
    }

}
