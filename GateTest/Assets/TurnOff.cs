using UnityEngine;
using System.Collections;
using System;

public class TurnOff : MonoBehaviour
{
    public Toucher ts1;

	// Use this for initialization
	void Start ()
    {
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (ts1.touched == true)
        {
            gameObject.SetActive(false);
            print("Helloooo");
        }
    }
}
