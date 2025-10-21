using UnityEngine;
using UnityEngine.UI;
using TMPro; // Nếu dùng TextMeshPro

public class GameTime : MonoBehaviour
{
    public TextMeshProUGUI timerText; // Nếu dùng TextMeshPro
    // public Text timerText; // Nếu dùng UI Text thường

    private float elapsedTime = 0f;
    private bool isRunning = true;

    void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
            int minutes = Mathf.FloorToInt(elapsedTime / 60f);
            int seconds = Mathf.FloorToInt(elapsedTime % 60f);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    public float GetElapsedTime()
    {
        return elapsedTime;
    }

    public void StopTimer()
    {
        isRunning = false;
    }
}
