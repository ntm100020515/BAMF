using UnityEngine;
using System.Collections;
using System;

public class TestOne : MonoBehaviour
{
    public GameObject
        public static bool onoff = true;
    private TestScript otherScript;
    private bool a;
    

	// Use this for initialization
	void Start ()
    {
        a = otherScript.touched; 
	}
	
	// Update is called once per frame
	void Update ()
    {
        GameObject.Find("Thing").SetActive(onoff); 
	}
}
