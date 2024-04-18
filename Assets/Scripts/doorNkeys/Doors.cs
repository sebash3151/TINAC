using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    // Start is called before the first frame update
    public bool open = false;
    [SerializeField] float openDoorAngle;
    [SerializeField] float closeDoorAngle;
    [SerializeField] float smooth = 2f;
    [SerializeField] bool previousdoorstate = false;   
    AudioSource rechino;

    private void Start()
    {
        rechino = GetComponent<AudioSource>();
    }

    public void MoveDoor()
    {
        open = !open; //aqui si open = true, se va a poner en false, y viceversa
    }

    void Update()
    {
        if (open)
        {  //el quaternion es lo que usa unity para las rotaciones 
            Quaternion targetRotation = Quaternion.Euler(0, openDoorAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
        }   //esta es para que se mueva lento, es una funcion que ya viene en unity .slerp(dedonde, hastadonde, velocidad)
        else
        {
            Quaternion targetRotation2 = Quaternion.Euler(0, closeDoorAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, smooth * Time.deltaTime);
        }

        if (open != previousdoorstate)
        {
            rechino.Play();
            previousdoorstate = open;
        }
    }
}
