using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sombradistraida : MonoBehaviour
{
    Shadow_Comportamiento movimiento;
    Distraction distra;
    [SerializeField] float tiempodeoso;
    [SerializeField] float timeroso = 0f;
    bool activo;

    private void Start()
    {
        movimiento = GetComponentInChildren<Shadow_Comportamiento>();
        distra = GetComponentInChildren<Distraction>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Osito"))
        {
            if (timeroso >= 0 && timeroso <= tiempodeoso)
            {
                movimiento.enabled = false;
                distra.enabled = true;
                activo = true;
            }
        }
    }

    private void Update()
    {
        if (activo)
        {
            timeroso += Time.deltaTime;
            if (timeroso >= tiempodeoso)
            {
                movimiento.enabled = true;
                distra.enabled = false;
                timeroso = 0f;
                activo = false;
            }
        }
    }
}
