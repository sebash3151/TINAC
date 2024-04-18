using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Respawn : MonoBehaviour
{
    float timer;
    Player_Life vida;
    [SerializeField] float TiempoDeRespawn = 5;

    void Start()
    {
        vida = GetComponent<Player_Life>();
    }


    void Update()
    {
        Respawn();
    }

    void Respawn()
    {
        if (vida.VidaActual <= 0)
        {
            timer += Time.deltaTime;

            if (timer >= TiempoDeRespawn)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
