using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBeat_Player : MonoBehaviour
{
    AudioSource Heart;
    Player_Life vida;

    void Start()
    {
        Heart = GetComponent<AudioSource>();
        vida = GetComponentInParent<Player_Life>();
    }


    void Update()
    {
        Peligro();
    }

    void Peligro()
    {
        if (vida.VidaActual <= 30 && vida.VidaActual>=0)
        {
            if (!Heart.isPlaying) Heart.Play();
        }
        else
        {
            Heart.Stop();
        }
    }
}
