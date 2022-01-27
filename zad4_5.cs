using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad4_5 : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision);
        if(collision.gameObject.name == "Cube")
        {
            gameObject.transform.position += 10 *Vector3.up * Time.deltaTime;
            //gameObject.transform += Mathf.Sqrt(10f * -3.0f * 9.81f);
            
        }
    }
}
