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
        Vector2 CursorPos = Input.mousePosition;
        Vector2 playerPos = RectTransformUtility.WorldToScreenPoint(Camera.main, player.gameObject.transform.position);
        Vector2 dift = CursorPos - playerPos;
        if (dift.magnitude > player.MaxRange)
        {
            CursorPos = playerPos + dift.normalized * player.MaxRange;
        }

        //if()
        //{

        //}

        this.transform.position = CursorPos;
    }
}
