using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void LoadGame()
    {
        ScoreManager.instance.ResetScore(); 
        Debug.Log(" Score reset to 0");
        SceneManager.LoadScene("Level 1");
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void BackGame()
    {
        Debug.Log(" Back button pressed");
        SceneManager.LoadScene("Main Menu");
    }

    public void LoadGameGuide()
    {
        SceneManager.LoadScene("How To Play");
    }
}
