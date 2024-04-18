using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hiding : MonoBehaviour
{  
    [SerializeField] float camHeight = 0;//Variable modificable para definir que tanto baja la camara.
    bool CH = true;//variable publica CH = Capable of hiding(capacidad de esconderse)
    //Classes para acceder a la camara
    GameObject came;
    Transform Cam;
    Player_Life vida;
   
    void Start()
    {
        came = GameObject.Find("Camera");
        Cam = came.GetComponent<Transform>();
        vida = FindObjectOfType<Player_Life>();
    }

    private void OnTriggerStay(Collider other)
    {
        // se establece el jugador y los vectores que modificaran la altura de la camara
        GameObject Player = other.gameObject;
        Player_moverse sp = Player.GetComponent<Player_moverse>();
        Vector3 PasPoi = new Vector3(0, 0.6f, 0);
        Vector3 NewPoi = new Vector3(Cam.position.x, Cam.position.y * camHeight, Cam.position.z);
        // si presiona la 'e' y puede esconderse se esnconde frenandolo y bajando la camara
        if (Player.CompareTag("Player") && Input.GetKeyDown(KeyCode.E) && CH == true)
        {
            sp.movementSpeed = 0f;
            Cam.position = NewPoi;
            CH = false;
            vida.Escondido = true;
        }
        // si presiona la 'e' y no puede esconderse, lo deja moverse denuevo y devuelve la camara a la posicion original.
        else if (Input.GetKeyDown(KeyCode.E) && CH == false)
        {
            sp.movementSpeed = sp.movimientonormal;
            Cam.localPosition = PasPoi;
            CH = true;
            vida.Escondido = false;
        }      
    }







}
