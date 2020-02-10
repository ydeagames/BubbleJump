using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    public float span;
    private float time;
    public GameObject[] prefabs;
    public BoxCollider2D bounding;
    public Transform pool;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > span)
        {
            time = 0;
            var obj = Instantiate(prefabs[Random.Range(0, prefabs.Length)], pool);
            obj.transform.position = new Vector3(Random.Range(bounding.bounds.min.x, bounding.bounds.max.x), Random.Range(bounding.bounds.min.y, bounding.bounds.max.y));
        }
    }
}
