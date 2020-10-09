using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy_Eagle : MonoBehaviour
{
    private Rigidbody2D rb;

    public Transform Uppoint, Downpoint;

    public float Speed;
    private bool Faceup = true;
    private float Upy, Downy;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.DetachChildren();
        Upy = Uppoint.position.y;
        Downy = Downpoint.position.y;
        Destroy(Uppoint.gameObject);
        Destroy(Downpoint.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (Faceup)
        {
            rb.velocity = new Vector2(rb.velocity.x, Speed);
            if (rb.position.y > Upy)
            {
                Faceup = false;
            }
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, -Speed);
            if (rb.position.y < Downy)
            {
                Faceup = true;
            }
        }
    }
}
