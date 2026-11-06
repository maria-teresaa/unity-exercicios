using UnityEngine;
using TMPro;

public class mover_nivel_2 : MonoBehaviour
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
        grossao.AddForce(0,0,15);
        if(Input.touchCount>0)
        {
           Touch toque=Input.GetTouch(0);
           if (toque.position.x < Screen.width / 2)
            {
                grossao.AddForce(-55,0,0);
            }
            else
            {
                grossao.AddForce(55,0,0);
            }
        }
        if (transform.position.y < 0)
        {
            FindAnyObjectByType<controlador2>().restart();
        }
        
    }
    private void OnCollisionEnter (Collision barreira)
    {
        if (barreira.gameObject.tag == "barreiras")
        {
            Vida.text=(int.Parse(Vida.text)-1).ToString();
            if (int.Parse(Vida.text) <= 0)
            {
                FindAnyObjectByType<controlador2>().restart();
            }
            som.PlayOneShot(mau);
        }
        if (barreira.gameObject.tag == "fim")
        {
            FindAnyObjectByType<controlador2>().proximo();
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
