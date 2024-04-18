using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonSeleccionado : MonoBehaviour
{
    [SerializeField] string escena;
    [SerializeField] Color[] colores;
    [SerializeField] Button menutext;
    public bool seleccionado = false;
    [SerializeField] activepause pausa;
    [SerializeField] string yo;

    void Start()
    {
        menutext = GetComponent<Button>();
        menutext.image.color = colores[0];
    }


    void Update()
    {
        if (seleccionado)
        {
            menutext.image.color = colores[1];
        }
        else
        {
            menutext.image.color = colores[0];
        }

        if (Input.GetKeyDown(KeyCode.Return) && seleccionado)
        {
            if (yo == "reanudar")
            {
                pausa.reanudar();
            }
            if (yo == "menu")
            {
                Application.Quit();
            }
        }
    }
}
