using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;

    public float moveSpeed;
    public float jumpForce;
    private bool isJumping;
    private float moveHorizontal;
    private float moveVertical;

    Color lerpedColor = Color.blue;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

        moveSpeed = 3f;
        jumpForce = 60f;
        isJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
       
        /*
        rb.velocity = new Vector2(input * moveSpeed, rb.velocity.y);


        lerpedColor = Color.Lerp(Color.blue, Color.red, GetComponent<Rigidbody>().velocity.magnitude / 30);
        gameObject.GetComponent<SpriteRenderer>().material.color = lerpedColor;
        */

    }

    void FixedUpdate() 
    { 
        if(moveHorizontal > 0.1f || moveHorizontal < -0.1f) 
        {
            rb.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
        }
        print(moveHorizontal);
    }
}
