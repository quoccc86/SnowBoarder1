using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Update()
    {
        if (ScoreManager.instance != null && scoreText != null)
        {
            scoreText.text = "SCORE: " + ScoreManager.instance.GetScore();
        }
    }
}
