using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

    public float speed;

	void Update () {

        if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(Vector2.right * (speed*2));
            }
            else
            {
                transform.Translate(Vector2.right * speed);
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(Vector2.left * (speed * 2));
            }
            else
            {
                transform.Translate(Vector2.left * speed);
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(Vector2.up * (speed * 2));
            }
            else
            {
                transform.Translate(Vector2.up * speed);
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(Vector2.down * (speed * 2));
            }
            else
            {
                transform.Translate(Vector2.down * speed);
            }
        }

    }
}
