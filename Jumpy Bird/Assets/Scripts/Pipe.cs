using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float MoveSpeed = 5f;

    Bird bird;
    Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        bird = FindObjectOfType<Bird>();
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();

        rigidbody2D.velocity = new Vector2(-MoveSpeed, 0);
        rigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;

    }

    // Update is called once per frame
    void Update()
    {
        if(bird.IsDead)
            rigidbody2D.velocity = new Vector2(0, 0);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
