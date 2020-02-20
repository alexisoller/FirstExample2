using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public float speed;

    void Start()
    {
    }

    // Start is called before the first frame update
    void Update()
    {
        //transform.Translate(mov*speed*Time.deltaTime, 0,0);
        transform.Translate(speed * Time.deltaTime, 0, 0);
        float x = transform.position.x;
       
        if (x > 35)
        {
            speed = speed * -1;
        }
        else if (x < 19)
        {
            speed = speed * -1;
        }

        // Debug.Log(x);
        // Debug.Log(izDer);
    }
}
