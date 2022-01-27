using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad3_2 : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public float speed = 2.0f;
    private bool kierunekPrzod;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        kierunekPrzod = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(kierunekPrzod)
            rb.transform.Translate(speed * Time.deltaTime, 0, 0);
        else
            rb.transform.Translate(-(speed * Time.deltaTime), 0, 0);


        if (rb.transform.position.x >= 10)
            kierunekPrzod = false;
        else if(rb.transform.position.x <=0)
            kierunekPrzod = true;
    }
}
