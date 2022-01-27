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
        // pobranie warto�ci zmiany pozycji w danej osi
        // warto�ci s� z zakresu [-1, 1]
        // kontroler ruchu dla osi jest pobierany z domy�lnych ustawie�
        // Input Manager (preferences)
        float mH = Input.GetAxis("Horizontal");
        float mV = Input.GetAxis("Vertical");

        // tworzymy wektor pr�dko�ci
        Vector3 velocity = new Vector3(mH, 0, mV);
        velocity = velocity.normalized * speed * Time.deltaTime;
        // wykonujemy przesuni�cie Rigidbody z uwzgl�dnieniem si� fizycznych
        rb.MovePosition(transform.position + velocity);
    }
}
