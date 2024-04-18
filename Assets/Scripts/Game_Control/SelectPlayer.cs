using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPlayer : MonoBehaviour
{
    GameObject[] Personajes;

    void Awake()
    {
        Personajes = new GameObject[transform.childCount];
        for(int i = 0; i < Personajes.Length; i++)
        {
            Personajes[i] = transform.GetChild(i).gameObject;
            Personajes[i].SetActive(false);
        }
        Personajes[Player_Difficult_selector.Personaje].SetActive(true);
    }
}
