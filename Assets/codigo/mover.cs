using UnityEngine;
using TMPro;

public class mover : MonoBehaviour
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
            FindAnyObjectByType<controlador>().reiniciar();
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
        if (barreira.gameObject.tag == "fim")
        {
            FindAnyObjectByType<controlador>().passou();
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
