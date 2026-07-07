using UnityEngine;

public class ButtonHider : MonoBehaviour
{
    public GameObject Button;
    
    void Start()
    {
        Button.SetActive(true);
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Button.activeSelf && PauseController.IsGamePaused)
            {
                return;
            }
            
            Button.SetActive(!Button.activeSelf);
            PauseController.SetPause(Button.activeSelf);

        }
    }
}