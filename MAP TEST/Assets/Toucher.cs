using UnityEngine;
using System.Collections;

public class Toucher : MonoBehaviour
{
    public bool touched = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        touched = true;
        
    }
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}
}
