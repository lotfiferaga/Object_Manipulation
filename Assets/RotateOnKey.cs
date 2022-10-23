using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnKey : MonoBehaviour
{ 
    public float speed = 40f;
    public string button;
    public bool onoff = false ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        
        if(Input.GetKeyDown(button))
        {
            onoff =!onoff;
        }
            if(onoff) {
            transform.Rotate(new Vector3(0,speed,0)* Time.deltaTime);
            }
         
        
    }
}