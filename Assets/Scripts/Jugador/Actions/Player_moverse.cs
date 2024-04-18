using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_moverse : MonoBehaviour
{
    public float movementSpeed;
    public float movimientonormal;
    [SerializeField] float velocidadCorrer;
    float stamina;
    [SerializeField] float staminainicial;
    bool corriendo;
    public bool cansado;

    float gravity = -10;  
    float vSpeed = 0;
    CharacterController charController; 
    Vector3 speed;

    [SerializeField] Slider sliderstamina;

    private void Awake()
    {
        charController = GetComponent<CharacterController>();
        movementSpeed = movimientonormal;
        stamina = staminainicial;
    }

    private void Start()
    {
        sliderstamina.maxValue = staminainicial;
    }

    void Update()
    {
        Correcion();
        Mover();
        gravedad();
        actuializarstamina();
    }

    void Correcion()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && stamina > 0)
        {
            movementSpeed = movimientonormal * velocidadCorrer;
            corriendo = true;
            cansado = false;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift) || stamina <= 0)
        {
            movementSpeed = movimientonormal;
            corriendo = false;
            cansado = true;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            stamina -= Time.deltaTime;
        }

        if (stamina == 0 || corriendo == false )
        {
            stamina += Time.deltaTime/2;
        }

        if (stamina >= staminainicial)
        {
            stamina = staminainicial;
            cansado = false;
        }
    }

    public void Mover()
    {
        Vector3 forwardSpeed = transform.forward * Input.GetAxis("Vertical") * movementSpeed;
        Vector3 rightSpeed = transform.right * Input.GetAxis("Horizontal") * movementSpeed;
        speed = forwardSpeed + rightSpeed;
    }

    void gravedad()
    {
        if (charController.isGrounded)
        {
            vSpeed = 0;
        }
        vSpeed += gravity;
        speed.y = vSpeed;
        charController.Move(speed * Time.deltaTime);
    }

    void actuializarstamina()
    {
        sliderstamina.value = stamina;
    }
}
