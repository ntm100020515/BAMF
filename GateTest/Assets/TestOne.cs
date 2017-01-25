using UnityEngine;
using System.Collections;
using System;

public class TestOne : MonoBehaviour
{
    public bool onoff = false;
    
    

	// Use this for initialization
	void Start ()
    {
        gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update ()
    {        
        
        if(onoff == true)
        {
            gameObject.SetActive(false);
        }


    }
}
