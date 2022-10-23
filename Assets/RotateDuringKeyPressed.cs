using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDuringKeyPressed : MonoBehaviour
{
    public float speed = 40f;
    public string button ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       /* if(Input.GetButtonDown("Rotate"))
        {
            //print("rotating");

            transform.Rotate(new Vector3(0,speed,0)* Time.deltaTime);
        } */

        if(Input.GetKey(button))
        {
            //print("rotating");

            transform.Rotate(new Vector3(0,speed,0)* Time.deltaTime);
        }
    }
}




