using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickUp : MonoBehaviour
{
    public bool key = false;
    public bool key2 = false;
    [SerializeField] float InteractDistance = 1.5f;
    [SerializeField] GameObject KeyImage;
    [SerializeField] GameObject Key2Image;

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            Ray ray = new Ray(transform.position, transform.forward); //este es el rayo y pues la direccion
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, InteractDistance)) //este es basicamente cuando el rayo toque algo en el alcance, osea el interact distance
            {
                if (hit.collider.CompareTag("Key"))
                {
                    hit.collider.transform.gameObject.SetActive(false);
                    key = true;
                }
                else if (hit.collider.CompareTag("Key2"))
                {
                    hit.collider.transform.gameObject.SetActive(false);
                    key2 = true;
                }
            }
        }
        ActualizarImagen();
    }

    void ActualizarImagen()
    {
        if (key)
        {
            KeyImage.SetActive(true);
        }
        if (key2)
        {
            Key2Image.SetActive(true);
        }
    }
}
