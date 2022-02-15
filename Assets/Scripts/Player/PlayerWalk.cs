using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    // 스피드, 최대 체력, 현재 체력, 공격력, 쿨타임
    public float speed;
    public float maxHP;
    public float currentHP;
    public float attackPower;
    public float coolDown;

    Rigidbody2D rigid;
    float h;
    float v;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();

        // 수치 초기화
        speed = 100;
        maxHP = 100;
        currentHP = 100;
        attackPower = 100;
        coolDown = 100;
    }

    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // 플레이어 이동
        if (h < 0) transform.localScale = new Vector3(-1, 1, 1);
        else if (h > 0) transform.localScale = new Vector3(1, 1, 1);

        rigid.velocity = new Vector2(h, v) * speed * Time.deltaTime;
    }
}
