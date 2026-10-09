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
        grossao.linearVelocity=new Vector3(0,0,10f);
    }
}
