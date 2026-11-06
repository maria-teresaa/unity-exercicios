using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class controlador2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void restart()
    {
        SceneManager.LoadScene("nivel 2");
    }
    public void proximo()
    {
       SceneManager.LoadScene("menu");
    }
}
