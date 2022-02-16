using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocity;
    public int jumpforce;
    private float moveHorizontal;
    private float moveVertical;



    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        moveHorizontal =Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxis("Vertical");


    }

    private void FixedUpdate()
    {
        if (moveHorizontal> 0.1f || moveHorizontal<0.1f)
        {
            rb.AddForce(new Vector2(velocity*moveHorizontal, 0), ForceMode2D.Impulse);
        }

        if (moveVertical >0.1f && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector2(0,jumpforce), ForceMode2D.Impulse);
        }
    }

}
