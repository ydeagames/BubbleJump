using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// プレイヤークラス
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigid;
    // ジャンプ力
    public float jumpPower = 1;
    // 移動力
    public float movePower = 0.5f;
    // 床当たり判定
    public Collider2D footCollider;
    // 床あたり
    public LayerMask footLayerMask;
    // エフェクト
    public ParticleSystem particle;

    private float move;
    private bool jump;
    private bool jumpable;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 移動
        move = Input.GetAxis("Horizontal");

        // ジャンプ
        // if (footCollider.IsTouchingLayers(footLayerMask.value))
        /*
        if (jumpable)
        {
            if (Input.GetButtonDown("Jump"))
            {
                jumpable = false;
                jump = true;
            }
        }
        */
    }

    void FixedUpdate()
    {
        // 移動
        rigid.AddForce(new Vector2(move * movePower, 0));
        // var vel = rigid.velocity;
        // vel.x = Input.GetAxis("Horizontal") * movePower;
        // rigid.velocity = vel;

        //if (footCollider.IsTouchingLayers(footLayerMask.value))
        /*
        {
            // ジャンプ
            if (jump)
            {
                rigid.AddForce(Vector2.up * jumpPower);
                jump = false;
            }
        }
        */
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // jumpable = true;
        //rigid.AddForce(Vector2.up * (rigid.velocity.y) * jumpPower);
        if (particle != null)
            Instantiate(particle).transform.position = transform.position;
    }
}
