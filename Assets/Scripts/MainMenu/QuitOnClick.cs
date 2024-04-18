using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitOnClick : MonoBehaviour
{
    // con esto al undir en el boton si se esta corriendo el juego en el editor se cierra, si esta en la aplicacion, la cierra.
    public void Quit()
    {
#if UNITY_EDITOR 
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif

    }

}
