using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // giữ lại khi chuyển scene
        }
        else
        {
            Destroy(gameObject); // tránh nhân đôi khi quay lại Main Menu
        }
    }
}
