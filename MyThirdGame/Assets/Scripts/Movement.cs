using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float jumpforce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movements();
    }

    void Movements()
    {
        float horizontal_move = Input.GetAxis("Horizontal");
        float face_direction = Input.GetAxisRaw("Horizontal");

        if (horizontal_move != 0)
        {
            rb.velocity = new Vector2(horizontal_move * speed, rb.velocity.y);
        }

        if (face_direction != 0)
        {
            transform.localScale = new Vector3(face_direction, 1, 1);
        }

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
        }
    }
}
