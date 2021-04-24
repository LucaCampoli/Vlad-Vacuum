using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMovement : MonoBehaviour
{

    public float moveSpeed = 2f;
    public GameObject Ghost_Prefab;
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
        if (rb.position.y >= 4.5f)
        {
            //Destroy(this.Ghost_Prefab);
            Destroy(GameObject.Find("Ghost_Prefab(Clone)"), 0);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(this.Ghost_Prefab);
    }
}
