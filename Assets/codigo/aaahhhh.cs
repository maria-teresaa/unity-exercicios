using UnityEngine;

public class aaahhhh : MonoBehaviour
{
    public Rigidbody grossao;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

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
}
