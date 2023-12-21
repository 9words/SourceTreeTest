using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneformSpawner : MonoBehaviour
{
    public GameObject planeform;
    Vector3 lastpos;
    float size;
   public bool gameover;

    // Start is called before the first frame update
    void Start()
    {
        lastpos = transform.position;
        size = planeform.transform.localScale.x;
        for(int i=0;i<20;i++)
        {
            Randominstan();
        }
        InvokeRepeating("Randominstan",2f,0.2f);
    }
    void Randominstan()
    {
        
        float rand=Random.Range(0, 6);
        if(rand<3)
        {
            SpawnX();
        }
        else if(rand>=3)
         {
            SpawnY();
        }


    }
    // Update is called once per frame
    void Update()
    {
        if (gameover)
        {
            CancelInvoke("Randominstan");
        }
    }
    void SpawnX()
    {
        Vector3 temppos = lastpos;
        temppos.x += size;
        lastpos = temppos;

        Instantiate(planeform, lastpos, Quaternion.identity);
    }
    void SpawnY()
    {
        Vector3 temppos = lastpos;
        temppos.z += size;
        lastpos = temppos;

        Instantiate(planeform, lastpos, Quaternion.identity);
    }
}
