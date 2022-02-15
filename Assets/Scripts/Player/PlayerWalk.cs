using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    // ���ǵ�, �ִ� ü��, ���� ü��, ���ݷ�, ��Ÿ��
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

        // ��ġ �ʱ�ȭ
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
        // �÷��̾� �̵�
        if (h < 0) transform.localScale = new Vector3(-1, 1, 1);
        else if (h > 0) transform.localScale = new Vector3(1, 1, 1);

        rigid.velocity = new Vector2(h, v) * speed * Time.deltaTime;
    }
}
