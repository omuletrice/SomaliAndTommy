using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [Range(0, 10)]
    public float MoveSpeed;
    [Range(0, 1000)]
    public float flap;
    Rigidbody2D rd2d;
    bool Jump = false;

    // Use this for initialization
    void Start()
    {

        rd2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-MoveSpeed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(MoveSpeed, 0, 0);
        }

         if (Input.GetKeyDown(KeyCode.Z) && ! Jump)
        {
            rd2d.AddForce(Vector2.up * flap);
            Jump = true;
            Debug.Log("true");
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
    void OnCollisionEnter2D(Collision2D on)
    {
        if (on.gameObject.CompareTag("Ground"))
        {
            Jump = false;
            Debug.Log("着地してるよ");
        }
    }
}
