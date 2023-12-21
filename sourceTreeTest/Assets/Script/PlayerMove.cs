using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        float xinput = Input.GetAxis("Horizontal")*speed;
        float yinput = Input.GetAxis("Vertical")*speed;

       rb.velocity = new Vector3(xinput,0,yinput);
    }
}
