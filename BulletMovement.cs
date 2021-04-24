using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

    public float moveSpeed = 2f;
    public GameObject Bullet;
    public Rigidbody2D rb;
    Vector2 movement;


    // Start is called before the first frame update
    void Start()
    {
        movement.y = 0.5f;
    }

    void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + movement * -moveSpeed * Time.fixedDeltaTime);
        if (Time.fixedDeltaTime > 5 || rb.position.y >= 4.8f)
        {
            Destroy(GameObject.Find("Bullet(Clone)"), 0);
        }
    }
}