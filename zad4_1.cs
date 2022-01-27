using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class zad4_1 : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    public int objectsCount = 10;
    int objectCounter = 0;
    public GameObject block;
    public List<Material> materials = new List<Material>();

    void Start()
    {
        float xScale = (this.transform.localScale.x * 10)/2;
        float zScale = (this.transform.localScale.z * 10)/2;

        for (int i = 0; i < objectsCount; i++)
        {
            this.positions.Add(new Vector3(Random.Range(-xScale, xScale), 0.5f, Random.Range(-zScale, zScale)));
        }

        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        foreach (Vector3 pos in positions)
        {
            this.block.GetComponent<MeshRenderer>().material = materials.ElementAt(Random.Range(0, materials.Count));
            Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            yield return new WaitForSeconds(this.delay);
        }
        StopCoroutine(GenerujObiekt());
    }
}
