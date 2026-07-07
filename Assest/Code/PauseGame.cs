using UnityEngine;

public class PauseGame : MonoBehaviour
{
    bool isPaused = false;

    void Update()
    {
        //pause and resume
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                Resume();
            else
                Pause();
        }
    }

    void Pause()
    {
        Time.timeScale = 0f;
        isPaused = true;
        Debug.Log("Game Paused");
    }

    void Resume()
    {
        Time.timeScale = 1f;
        isPaused = false;
        Debug.Log("Game Resumed");
    }
}
