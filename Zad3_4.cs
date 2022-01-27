using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad3_4 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;
    private List<Vector3> positions;

    Vector3 getRandomPosition()
    {
        var position = new Vector3(Random.Range(-5.0f, 5.0f), 0.5f, Random.Range(-5.0f, 5.0f));
        return position;
    }
    void Start()
    {
        positions = new List<Vector3>();
        for (int i = 0; i < 10; i++)
        {

            var position = getRandomPosition();
            while(positions.Contains(position))
            {
                Debug.Log("zawiera");
                position = getRandomPosition();
            }
            positions.Add(position);
            Instantiate(cube, position, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
