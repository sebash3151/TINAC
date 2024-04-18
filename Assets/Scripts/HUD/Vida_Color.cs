using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida_Color : MonoBehaviour
{
    [SerializeField] Color Sara=new Color();
    [SerializeField] Color Edmund = new Color();
    [SerializeField] Color Geoffrey = new Color();
    Image barra;

    void Awake()
    {
        barra = GetComponent<Image>();
        cambio_color();
    }

    void cambio_color()
    {
        if (Player_Difficult_selector.Personaje == 0)
        {
            barra.color = Sara;
        }
        else if (Player_Difficult_selector.Personaje == 1)
        {
            barra.color = Edmund;
        }
        else if (Player_Difficult_selector.Personaje == 2)
        {
            barra.color = Geoffrey;
        }
    }
}
