using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour
{
    public bool touched = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        touched = true;
        print("Trigger Touched");
    }
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(touched == true)
        {
            print("true");
        }
	}
}
