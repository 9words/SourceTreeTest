using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag=="Ball")
        {
            Invoke("Falldown", 0.5f);
        }
    }
    void Falldown()
    {
       GetComponentInParent<Rigidbody>().useGravity = true;
       // Destroy(transform.gameObject);
        Destroy(transform.parent.gameObject, 2f);
    }
}
