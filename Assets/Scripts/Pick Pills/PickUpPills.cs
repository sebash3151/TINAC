using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPills : MonoBehaviour
{
    Player_Life Life;
    [SerializeField] int regeneration = 30;
    AudioSource sonido;
    
    void Start()
    {
        Life = FindObjectOfType<Player_Life>();
        facil();
        Dificil();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player"&&Life.VidaActual<100)
        {
            Life.VidaActual += regeneration;
            Destroy(gameObject);
        }               
    }

    void facil()
    {
        if (Player_Difficult_selector.Difficult == 1)
        {
            regeneration = regeneration * 2;
        }
    }

    void Dificil()
    {
        if (Player_Difficult_selector.Difficult == 2)
        {
            regeneration = regeneration / 2;
        }
    }
}
