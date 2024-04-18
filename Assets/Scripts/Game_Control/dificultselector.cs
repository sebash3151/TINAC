using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dificultselector : MonoBehaviour
{
    GameObject[] dificultades;

    void Awake()
    {
        dificultades = new GameObject[transform.childCount];
        for (int i = 0; i < dificultades.Length; i++)
        {
            dificultades[i] = transform.GetChild(i).gameObject;
            dificultades[i].SetActive(false);
        }
        dificultades[Player_Difficult_selector.Difficult-1].SetActive(true);
    }
}
