using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    private Canvas cv;
    void Start()
    {
        cv = GameObject.Find("Canvas").GetComponent<Canvas>();
        cv.enabled = false;
    }

    
    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape)){
            cv.enabled = !cv.enabled;
            

            if (Time.timeScale == 0) {
                Time.timeScale = 1;
            } else{
                Time.timeScale = 0;
            }
        }
        
    }



    public void buttonStart() {

        Time.timeScale = 1;
        cv.enabled = false;

    }
    public void buttonSettings() {
        Debug.Log("Start Button");
    }


}
