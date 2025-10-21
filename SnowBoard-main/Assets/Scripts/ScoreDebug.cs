using UnityEngine;

public class ScoreDebug : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Final Score in Game Over: " + ScoreManager.finalScore);
    }
}
