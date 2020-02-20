using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goal_Colision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter() {

        SceneManager.LoadScene("Goal");
    }


    // Update is called once per frame
    void Update(){
        
    }
}
