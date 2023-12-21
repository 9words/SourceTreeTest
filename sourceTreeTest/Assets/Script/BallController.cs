using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    bool started;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        started = false;
        
    }

    // Update is called once per frame
    void Update()
    {
      if(started==false)
        {
            rb.velocity = new Vector3(0, 0, speed);
            started = true;
        }
        if(Input.GetMouseButton(0))
        {
           
            switchDirection();
        }
         
    }
    
    void switchDirection()
    {
        if (rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(speed, 0, 0);
        }
        else if (rb.velocity.x > 0)
        {
            
            rb.velocity = new Vector3(0, 0, speed);
        }
       
    }
}
