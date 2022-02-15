using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public float speed;

    Rigidbody2D rigid;
    float h;
    float v;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        speed = 100;
    }

    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if (h < 0) transform.localScale = new Vector3(-1, 1, 1);
        else if (h > 0) transform.localScale = new Vector3(1, 1, 1);

        rigid.velocity = new Vector2(h, v) * speed * Time.deltaTime;
    }
}
