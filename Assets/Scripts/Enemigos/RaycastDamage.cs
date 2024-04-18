using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastDamage : MonoBehaviour
{
    Light Litch;

    [SerializeField] float Switche;
    [SerializeField] float LanternRange;

    // CapsuleCollider LinternaRange;


    void Start()
    {
        Litch = GetComponent<Light>();
        //LinternaRange = GetComponent<CapsuleCollider>();
    }


    void Update()
    {
        if (Switche == 1f)
        {
            Encender();
        }

        if (Switche == 0f)
        {
            Apagar();
        }

        if (Switche == 0f && Input.GetButtonDown("Fire1"))
        {
            Switche = 1f;
        }
        else if (Switche == 1f && Input.GetButtonDown("Fire1"))
        {
            Switche = 0f;
        }
    }

    void Encender()
    {
        Litch.range = 20f;
        LanternRange = 3f;
        Ray ray = new Ray(transform.position, transform.forward); //este es el rayo y pues la direccion
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, LanternRange)) //este es basicamente cuando el rayo toque algo en el alcance, osea el interact distance
        {
            if (hit.collider.CompareTag("Sombra"))
            {
                //hit.collider.transform.parent.GetComponent<Doors>().MoveDoor();
            }
        }
        //LinternaRange.enabled = true;
    }
    void Apagar()
    {
        Litch.range = 0f;
        LanternRange = 0;
        //LinternaRange.enabled = false;
    }
}
