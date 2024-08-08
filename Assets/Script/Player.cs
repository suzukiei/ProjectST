using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    [SerializeField,Header("移動速度")]private float Speed;

    private Vector2 inputVelocity; //Vector2はx,y軸
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        inputVelocity = Vector2.zero; //x,yの値は0
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        rb.velocity = inputVelocity * Speed;

    }

    public void OnMove(InputAction.CallbackContext context)
    {
        inputVelocity = context.ReadValue<Vector2>();
    }
}
