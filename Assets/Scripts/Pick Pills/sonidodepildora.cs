using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidodepildora : MonoBehaviour
{
    PickUpPills pildora;
    AudioSource sonido;
    float timer;
    [SerializeField] float selfdestruct;

    private void Start()
    {
        pildora = GetComponentInChildren<PickUpPills>();
        sonido = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (pildora == null)
        {
           if(!sonido.isPlaying) sonido.Play();
           timer += Time.deltaTime;           
        }

        if (timer >= selfdestruct)
        {
            Destroy(gameObject);
        }
    }
}
