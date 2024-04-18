using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Edmund : MonoBehaviour
{
    [SerializeField] GameObject Botella;
    [SerializeField] GameObject esfera;
    [SerializeField] float magnitudDisparo = 711.177f;
    Transform posicionEsfera;

    [SerializeField] bool poderdisparar;
    [SerializeField] float cooldown = 5f;
    [SerializeField] float controltiempo = 0f;
    [SerializeField] Slider slider;

    void Awake()
    {
        posicionEsfera = esfera.GetComponent<Transform>();
        poderdisparar = true;
        slider.maxValue = cooldown;
        slider.value = cooldown;
    }
   
    void Update()
    {
        Disparar();
    }

    void Disparar()
    {
        if (Input.GetButtonDown("Fire2") && poderdisparar==true)
        {
            GameObject botellas = Instantiate(Botella, transform.position, transform.rotation);
            Rigidbody rbBotellas = botellas.GetComponent<Rigidbody>();
            //Transform tBotellas = botellas.GetComponent<Transform>();
            Vector3 lanzamiento = transform.forward.normalized *magnitudDisparo * 1;
            botellas.transform.position = transform.position;
            rbBotellas.AddForce(lanzamiento);
            poderdisparar = false;
            slider.value = 0f;
        }

        if (poderdisparar == false)
        {
            controltiempo += Time.deltaTime;
            slider.value = controltiempo;
        }

        if (controltiempo >= cooldown)
        {
            poderdisparar = true;
            controltiempo = 0f;
            slider.value = cooldown;
        }
    }
}
