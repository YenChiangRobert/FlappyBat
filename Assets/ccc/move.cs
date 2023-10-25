using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class move : MonoBehaviour
{
    public gm ggm;
    public float velocity = 1;
    private Rigidbody2D rb;
    SerialPort sp = new SerialPort("COM3", 9600);
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sp.Open();
        sp.ReadTimeout = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        rb.velocity = Vector2.up * velocity;
        if(sp.IsOpen)
        {
            try
            {
                MoveObject(sp.ReadByte());
                print(sp.ReadByte());
            }
            catch(System.Exception)
            {

            }
        }
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        ggm.gameover();
    }
    void MoveObject(int d)
    {
        if(d==1)
        {
            
                rb.velocity = Vector2.up * velocity;
        }
    }
}
