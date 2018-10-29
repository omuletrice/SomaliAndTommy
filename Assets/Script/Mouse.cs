using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour {

    private Player player;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("cat").GetComponent<Player>();
    }
	
	// Update is called once per frame
	void Update () {

        Vector3 CursorPos = Input.mousePosition;

        Vector3 dift = CursorPos - player.gameObject.transform.position;
        if (dift.magnitude > player.MaxRange)
        {
            CursorPos = player.gameObject.transform.position + dift.normalized * player.MaxRange;
        }

        this.transform.position = CursorPos;
    }
}
