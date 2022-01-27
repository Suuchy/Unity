using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    //public float force = 5.0f;
    //public float y = 0.0f;
    Rigidbody rb;

    public Transform from;
    public Transform to;

    public float distancePerFrame;

    private float percentage = 0.05f;
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, percentage);

        //if (rb.velocity.y == 0)
        //{
        //rb.transform.Rotate(50, 90, 90, Space.Self);
        //}

        //rb.transform.Rotate(10, 0, 0, Space.Self);
        //rb.transform.Translate(0, 0, distancePerFrame);

        // prawdziwy dystans na 1 sekunde
        rb.transform.Translate(0, 0, distancePerFrame * Time.deltaTime);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if(rb.velocity.y==0)
        //{
        //    rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        //}
    }
}
