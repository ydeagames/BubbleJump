using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyabonController : MonoBehaviour
{
    Vector3 vec;
    // Start is called before the first frame update
    void Start()
    {
        vec = new Vector3(0.0f, 0.01f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += vec;

    }
}
