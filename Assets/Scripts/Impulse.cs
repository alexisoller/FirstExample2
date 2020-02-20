using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour
{

    public GameObject sphere;
    private float jumpValue=14;  
    // Start is called before the first frame update
    void Start()    {        
    }

    void OnCollisionEnter()
    {

        sphere.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpValue, ForceMode.Impulse);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
