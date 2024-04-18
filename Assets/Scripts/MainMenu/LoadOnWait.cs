using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnWait : MonoBehaviour
{
    [SerializeField] AudioSource menu;
    [SerializeField] double TiempoDeEspera = 4;
    [SerializeField] string Escena;
    double timer;

    private void Update()
    {
        timer += Time.deltaTime;
        CargarEscena();
    }

    void CargarEscena()
    {
        if (menu != null)
        {
            menu.Stop();
        }

        if (timer >= TiempoDeEspera)
        {
            SceneManager.LoadScene(Escena);
        }
    }
}
