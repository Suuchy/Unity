using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCube : MonoBehaviour
{

    Rigidbody rb;
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // pobranie wartoœci zmiany pozycji w danej osi
        // wartoœci s¹ z zakresu [-1, 1]
        // kontroler ruchu dla osi jest pobierany z domyœlnych ustawieñ
        // Input Manager (preferences)
        float mH = Input.GetAxis("Horizontal");
        float mV = Input.GetAxis("Vertical");

        // tworzymy wektor prêdkoœci
        Vector3 velocity = new Vector3(mH, 0, mV);
        velocity = velocity.normalized * speed * Time.deltaTime;
        // wykonujemy przesuniêcie Rigidbody z uwzglêdnieniem si³ fizycznych
        rb.MovePosition(transform.position + velocity);
    }
}
