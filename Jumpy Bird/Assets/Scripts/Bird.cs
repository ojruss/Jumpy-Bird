using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float JumpVelocity = 10f;

    public bool IsDead { get; set; }

    Rigidbody2D rigidbody2D;
    PolygonCollider2D polygonCollider2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        polygonCollider2D = gameObject.GetComponent<PolygonCollider2D>();

        IsDead = false;
        polygonCollider2D.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !IsDead)
            rigidbody2D.velocity = Vector2.up * JumpVelocity;
    }

    void OnBecameInvisible()
    {
        IsDead = true;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        IsDead = true;
        polygonCollider2D.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreController.instance.AddPoint();
    }
}
