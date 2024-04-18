using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool PausedGame;
    public GameObject MenuOfPause;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && PausedGame == false)
        {

            Pause();
            PausedGame = true;

        }
        if (Input.GetButtonDown("Jump") && PausedGame == true)
        {

            Resume();
            PausedGame = false;
        }
    }
    public void Resume()
    {
        MenuOfPause.SetActive(false);
        Time.timeScale = 1f;
    }
    void Pause()
    {
        MenuOfPause.SetActive(true);
        Time.timeScale = 0f;
    }


    public void Quit()
    {
        Debug.Log("WRYYYYYYYY");
    }

}

