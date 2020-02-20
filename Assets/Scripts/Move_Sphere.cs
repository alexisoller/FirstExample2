using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Sphere : MonoBehaviour {
    // Start is called before the first frame update

    public float forceValue ;
    public float jumpValue;
    private float y;

    private Rigidbody rb_sphere;
    private AudioSource auSour_sphere;

    void Start() {
        rb_sphere = GetComponent<Rigidbody>();
        auSour_sphere=GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update() {

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb_sphere.velocity.y)<0.01f) {
            rb_sphere.AddForce(Vector3.up * jumpValue,ForceMode.Impulse);
            auSour_sphere.Play();

        }
        
      


    }


    private void FixedUpdate()
    {
        rb_sphere.AddForce(new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"))*forceValue);

        y = transform.position.y;


        if (y < -3)
        {
            //transform.position = new Vector3(0, 0, 0);
            Application.LoadLevel(0);
            
        }
    }
}

