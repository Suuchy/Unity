using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad4_4 : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public float sensitivity = 200;
    void Start()
    {
        // zablokowanie kursora na �rodku ekranu, oraz ukrycie kursora
        // aby w UnityEditor ponownie pojawi� si� kursor (w�a�ciwie deaktywowac kursor w trybie play)
        // wciskamy klawisz ESC
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // pobieramy warto�ci dla obu osi ruchu myszy
        float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseYMove = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // wykonujemy rotacj� wok� osi Y

        player.Rotate(Vector3.up * mouseXMove);

        //if (this.transform.rotation.eulerAngles.x < 270.0f && this.transform.rotation.eulerAngles.x > 90.0f)
        if (this.transform.rotation.eulerAngles.z == 0)
        {
            transform.Rotate(new Vector3(-mouseYMove, 0f, 0f), Space.Self);
        }

    }
}
