using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [Range(0, 10)]
    public float MoveSpeed;

    [Range(0,1000)]
    public float flap;

    Rigidbody2D rigidbody;

    bool Jump = false;  

    // Use this for initialization
    void Start () {

        rigidbody = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {


        


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-MoveSpeed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(MoveSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.Z) && !Jump)
        {
            rigidbody.AddForce(Vector2.up * flap);

            Jump = true;    
        }


        //Vector2 add_Move = Vector2.zero;

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    add_Move.x = -MoveSpeed;
        //}
        //else if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    add_Move.x = MoveSpeed;
        //}

    }
    void OnCollisionEner2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Jump = false;
        }
    }
}
