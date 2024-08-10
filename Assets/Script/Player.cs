using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    [SerializeField,Header("移動速度")]private float Speed;
    [SerializeField,Header("Bullet")]private GameObject Bullet;
    [SerializeField,Header("発射時間")]private float ShootTime;

    private Vector2 inputVelocity; //Vector2はx,y軸
    private Rigidbody2D rb;
    private float ShootCount;

    // Start is called before the first frame update
    void Start()
    {
        inputVelocity = Vector2.zero; //x,yの値は0
        rb = GetComponent<Rigidbody2D>();
        ShootCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Shooting();
    }

    private void Move()
    {
        rb.velocity = inputVelocity * Speed;

    }

    private void Shooting()
    {
        ShootCount += Time.deltaTime;
        if (ShootCount < ShootTime) return;

        GameObject bulletObj = Instantiate(Bullet);
        bulletObj.transform.position = transform.position + new Vector3(0f, transform.lossyScale.y / 2.0f, 0f);
        ShootCount = 0.0f;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        inputVelocity = context.ReadValue<Vector2>();
    }
}
