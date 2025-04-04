using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public void JugarPong()
    {
        SceneManager.LoadScene("Ejercicio03 - pingpong");
    }
    public void Opciones()
    {
        Debug.Log("Opciones");
    }
    public void Salir() {
        Application.Quit();
    }
}
