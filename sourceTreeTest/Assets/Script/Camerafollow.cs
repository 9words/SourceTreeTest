using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public GameObject target;
    Vector3 offset;
    public float lerprate;//插值率
   public bool gameover;


    // Start is called before the first frame update
    void Start()
    {
       gameover = false;
       offset = target.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameover)
        {
            follow();
        }
      
    }
    void follow()
    {
        Vector3 pos = transform.position;
        Vector3 targetpos = target.transform.position-offset;
        pos = Vector3.Lerp(pos, targetpos, lerprate * Time.deltaTime);
        transform.position = pos;


    }
}
