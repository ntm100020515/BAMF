using UnityEngine;
using System.Collections;
using System;

public class TurnOff : MonoBehaviour
{
    public Toucher ts1;
    private int numTouched;
    public int numReq;

	// Use this for initialization
	void Start ()
    {
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (ts1.touched == true)
        {
            numTouched++;
        }
        if(numReq==numTouched)
        {
            gameObject.SetActive(false);
        }
    }
}
