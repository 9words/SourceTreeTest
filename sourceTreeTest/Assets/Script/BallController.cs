using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    bool started;
    bool gameover;
    public GameObject particle;
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
            if(Input.GetMouseButtonDown(0))
            {
               
                rb.velocity = new Vector3(0, 0, speed);
                started = true;
                GameManager.instance.startGame();
            }
           
        }
        if(Physics.Raycast(transform.position, Vector3.down, 2f)==false)
        {
            rb.velocity = new Vector3(0, -25f, 0);
            gameover = true;
            Camera.main.GetComponent<Camerafollow>().gameover = true;
            GameManager.instance.stopGame();
        }
       // Debug.DrawRay(transform.position, Vector3.down, Color.red);
        if(Input.GetMouseButtonDown(0)&&gameover==false)
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
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="diamond")
        {
            GameObject p=Instantiate(particle, col.gameObject.transform.position, Quaternion.identity);
     
            Destroy(col.gameObject);
            Destroy(p, 1f);

        }
    }
}
