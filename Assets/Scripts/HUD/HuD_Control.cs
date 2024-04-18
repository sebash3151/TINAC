using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuD_Control : MonoBehaviour
{
    Animator HudAnim;
    AudioSource muer;
    [SerializeField] Music musik;
    [SerializeField] Shadow_Controler shadowsong;

    void Start()
    {
        HudAnim = GetComponent<Animator>();
        muer = GetComponent<AudioSource>();
    }

    public void Hurt()
    {
        HudAnim.SetTrigger("Hurt");
    }

    public void Death()
    {
        if (!muer.isPlaying) muer.Play();
        musik.Desactivar();
        HudAnim.SetBool("Death",true);
        shadowsong.DangerSong.Pause();
    }

}
