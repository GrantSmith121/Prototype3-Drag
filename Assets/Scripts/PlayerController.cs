using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;

    public float moveSpeed = 5f;

    Color lerpedColor = Color.blue;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(input * moveSpeed, rb.velocity.y);


        lerpedColor = Color.Lerp(Color.blue, Color.red, GetComponent<Rigidbody>().velocity.magnitude / 30);
        gameObject.GetComponent<SpriteRenderer>().material.color = lerpedColor;


    }
}
