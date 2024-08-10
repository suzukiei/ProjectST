using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField,Header("�ʂ̑��x")] private float speed;
    [SerializeField,Header("�ʂ̈З�")] private int damage;

    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MOVE();
    }

    private void MOVE()
    {
        rb.velocity = transform.up * speed;
    }
}
