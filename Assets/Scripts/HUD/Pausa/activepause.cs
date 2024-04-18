using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class activepause : MonoBehaviour
{
    [SerializeField] GameObject pausemenu;
    [SerializeField] bool gamepause = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && gamepause == false)
        {
            gamepause = true;
            Time.timeScale=0f;
            pausemenu.SetActive(true);
        }
    }

    public void reanudar()
    {
        gamepause = false;
        Time.timeScale = 1f;
        pausemenu.SetActive(false);
    }
}
