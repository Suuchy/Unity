using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad3_3 : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 5.0f;

    private int kierunek = 0;
    //E=0;
    //N=1;
    //W=2;
    //s=3;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.transform.Translate(speed * Time.deltaTime, 0, 0);
        switch(kierunek)
        {
            case 0:
                if (rb.transform.position.x >= 10)
                {
                    kierunek++;
                    rb.transform.Rotate(0, -90, 0);
                }
                break;
            case 1:
                if (rb.transform.position.z >= 10)
                {
                    kierunek++;
                    rb.transform.Rotate(0, -90, 0);
                }
                break;
            case 2:
                if (rb.transform.position.x <= 0)
                {
                    kierunek++;
                    rb.transform.Rotate(0, -90, 0);
                }
                break;
            case 3:
                if (rb.transform.position.z <=0)
                {
                    kierunek = 0;
                    rb.transform.Rotate(0, -90, 0);
                }
                break;

        }
    }  
}
