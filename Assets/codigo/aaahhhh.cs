using UnityEngine;
using TMPro;

public class aaahhhh : MonoBehaviour
{
    public Rigidbody grossao;
    public TMP_Text Vida;
    public TMP_Text Pontos;
    public AudioSource som;
    public AudioClip bom;
    public AudioClip mau;
    // Update is called once per frame
    void Update()
    {
        grossao.AddForce(0,0,1);
        if(Input.GetKeyDown(KeyCode.A))
        {
           grossao.AddForce(-55,0,0); 
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            grossao.AddForce(55,0,0);
        }
    }
    private void OnCollisionEnter (Collision barreira)
    {
        if (barreira.gameObject.tag == "barreiras")
        {
            Vida.text=(int.Parse(Vida.text)-1).ToString();
            if (int.Parse(Vida.text) <= 0)
            {
                FindAnyObjectByType<controlador>().reiniciar();
            }
            som.PlayOneShot(mau);
        }
    }
    private void OnTriggerEnter (Collider moeda)
    {
        if (moeda.gameObject.tag == "moedas")
        {
            Pontos.text=(int.Parse(Pontos.text)+10).ToString();
            som.PlayOneShot(bom);
        }
    }
}
