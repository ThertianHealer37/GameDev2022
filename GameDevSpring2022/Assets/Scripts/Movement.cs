using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    public Transform target;
    public int velocity;
    



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if(Input.GetKeyDown("Horizontal"))
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 14f);


    }

  
}
