using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_move : MonoBehaviour
{
    
    private float z;
    private float mov=1;
    private Rigidbody rb_cube;
    public float forceValue;

    // Start is called before the first frame update
    void Start()
    {
        rb_cube = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

         
    }
    private void FixedUpdate()
    {
        rb_cube.AddForce(new Vector3(0, 0, mov) * forceValue);

        z = transform.position.z;
        if (z < 2.4065){
            mov = mov * -1;
        }else if (z > -10){
            mov = mov * -1;
        }
    }



}
