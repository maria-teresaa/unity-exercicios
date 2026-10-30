using UnityEngine;
using TMPro;

public class controlador : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void reiniciar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("nivel 1");
    }
    public void passou()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("nivel 2");
    }
}
