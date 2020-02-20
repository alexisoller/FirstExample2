using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart_position : MonoBehaviour
{
    private float y ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        y = transform.position.y;


        if (y<-3) {

            transform.position = new Vector3(0, 0, 0);
        }

    }
}
