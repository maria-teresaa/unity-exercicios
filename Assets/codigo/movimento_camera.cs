using UnityEngine;

public class movimento_camera : MonoBehaviour
{
    public Transform jogador;
    public Vector3 distancia;
    // Update is called once per frame
    void Update()
    {
        transform.position=jogador.position+distancia;
    }
}
