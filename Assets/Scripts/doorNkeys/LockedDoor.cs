using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    [SerializeField] float interactdistance;

    void Update()
    {

        if (Input.GetKeyDown("e"))
        {
            KeyPickUp keyCheck = GetComponent<KeyPickUp>();
        
            Ray ray = new Ray(transform.position, transform.forward); //este es el rayo y pues la direccion
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, interactdistance)) //este es basicamente cuando el rayo toque algo en el alcance, osea el interact distance
            {
                if (hit.collider.CompareTag("LockedDoor") && keyCheck.key)
                {
                    hit.collider.transform.parent.GetComponent<Doors>().MoveDoor();
                }
            }
        }
    }
}
