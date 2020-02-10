using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyabonPlayerController : MonoBehaviour
{
    float jumpForce = 780.0f;
    Rigidbody2D rigid2D;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Syabon")
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce/2);
            Destroy(other.gameObject);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.05f, 0.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.05f, 0.0f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.Space) && this.rigid2D.velocity.y == 0)
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }
    }

}
