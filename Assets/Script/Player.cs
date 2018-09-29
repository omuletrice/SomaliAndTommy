using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [Range(0, 10)]
    public float MoveSpeed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        bool Jump = false;


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
}
