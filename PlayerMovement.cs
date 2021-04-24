using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Movement
        if (rb.position.x < -11.5 && movement.x < 0)
        {
            movement.x = 0;
        }
        if (rb.position.x > 11.5 && movement.x > 0)
        {
            movement.x = 0;
        }
        if (rb.position.y < -4.5 && movement.y < 0)
        {
            movement.y = 0;
        }
        if (rb.position.y > 4.5 && movement.y > 0)
        {
            movement.y = 0;
        }
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}