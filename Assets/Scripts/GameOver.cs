using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void LoadMainMenu()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene("Game Over");
    }
}
