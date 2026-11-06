using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class controlador : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void reiniciar()
    {
        SceneManager.LoadScene(1);
    }
    public void passou()
    {
       SceneManager.LoadScene(2);
    }
}
