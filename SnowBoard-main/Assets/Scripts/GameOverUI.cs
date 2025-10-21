using UnityEngine;
using TMPro;

public class GameOverUI : MonoBehaviour
{
    public TextMeshProUGUI finalScoreText;
    public TextMeshProUGUI highScoreText;

    void Start()
    {
        int currentScore = ScoreManager.instance.GetScore();
        finalScoreText.text = "Final Score: " + currentScore;

        // Lưu điểm cao nhất nếu cần
        ScoreManager.instance.SaveHighScore();

        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "High Score: " + highScore;
    }
}
