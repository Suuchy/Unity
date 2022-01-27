using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listing2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public float sensitivity = 200;
    void Start()
    {
        // zablokowanie kursora na œrodku ekranu, oraz ukrycie kursora
        // aby w UnityEditor ponownie pojawi³ siê kursor (w³aœciwie deaktywowac kursor w trybie play)
        // wciskamy klawisz ESC
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // pobieramy wartoœci dla obu osi ruchu myszy
        float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseYMove = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // wykonujemy rotacjê wokó³ osi Y
        player.Rotate(Vector3.up * mouseXMove);

        // a dla osi X obracamy kamerê
        transform.Rotate(new Vector3(-mouseYMove, 0f, 0f), Space.Self);
    }
}
