using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetectInteraction : MonoBehaviour
{
    [SerializeField] GameObject interactableButton;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Door") || other.gameObject.CompareTag("LockedDoor") || other.gameObject.CompareTag("LockedDoor2") || other.gameObject.CompareTag("Ritual") || other.gameObject.CompareTag("Nota") || other.gameObject.CompareTag("Key") || other.gameObject.CompareTag("Hiding"))
        {
            interactableButton.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Door") || other.gameObject.CompareTag("LockedDoor") || other.gameObject.CompareTag("LockedDoor2") || other.gameObject.CompareTag("Ritual") || other.gameObject.CompareTag("Nota") || other.gameObject.CompareTag("Key") || other.gameObject.CompareTag("Hiding"))
        {
            interactableButton.SetActive(false);
        }
    }
}
