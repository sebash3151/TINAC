using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour
{

    [SerializeField] Doors[] prts;
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("e"))
        {
            KeyPickUp keyCheck = GetComponent<KeyPickUp>();
            if (other.CompareTag("Door"))
            {
                other.transform.parent.GetComponent<Doors>().MoveDoor();
            }
            if (other.CompareTag("LockedDoor") && keyCheck.key)
            {
                other.transform.parent.GetComponent<Doors>().MoveDoor();
            }
            if (other.CompareTag("LockedDoor2") && keyCheck.key2)
            {
                other.transform.parent.GetComponent<Doors>().MoveDoor();
            }
        }
        if (Input.GetKeyDown("f"))
        {
            for (int i = 0; i < prts.Length; i++)
            {
                if (other.CompareTag("LockedDoor2"))
                {
                    other.transform.parent.GetComponent<Doors>().MoveDoor();
                }
                if (other.CompareTag("Door"))
                {
                    other.transform.parent.GetComponent<Doors>().MoveDoor();
                }
                if (other.CompareTag("LockedDoor"))
                {
                    other.transform.parent.GetComponent<Doors>().MoveDoor();
                }
            }
        }
    }
}

