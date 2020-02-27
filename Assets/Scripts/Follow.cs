using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Follow : MonoBehaviour
{

    public GameObject target;
    private Vector3 offset;
    float currenTime = 0f;
    float startingTime = 15f;
    public Text countdowntext;

    // Start is called before the first frame update
    void Start(){
        currenTime = startingTime;
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update(){
        currenTime -= 1 * Time.deltaTime;

        if (currenTime < 0.0000002) {
            SceneManager.LoadScene("END");
        }

        countdowntext.text = currenTime.ToString();
        transform.position = target.transform.position+offset;
    }
}
