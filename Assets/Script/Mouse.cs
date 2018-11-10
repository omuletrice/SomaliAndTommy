using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour {

    private Player player;



    // Use this for initialization
    void Start() {
        player = GameObject.Find("cat").GetComponent<Player>();
    }
	
	// Update is called once per frame
	void Update () {

        Vector2 CursorPos = Input.mousePosition;

        Vector2 playerPos = RectTransformUtility.WorldToScreenPoint(Camera.main, player.gameObject.transform.position);

        Vector2 curpos = RectTransformUtility.WorldToScreenPoint(Camera.main, CursorPos);

        Vector2 dift = CursorPos - playerPos;


        if (dift.magnitude > player.MaxRange)
        {
            CursorPos = playerPos + dift.normalized * player.MaxRange;
        
        this.transform.position = CursorPos;
        

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(CursorPos);
            RaycastHit2D[] hit_list;

            hit_list = Physics2D.RaycastAll(ray.origin,
                ray.direction,player.MaxRange);


            for (int i = 0; i < hit_list.Length; i++)
            {
                if (hit_list[i].collider != null)
                {

                    if(hit_list[i].transform.tag  == "Ground")
                    {
                        //Cursorの位置にPlayerを移動させる
                        Vector2 pos = Camera.main.ScreenToWorldPoint(CursorPos);
                        player.transform.position = pos;
                    }

                    else if(hit_list[i].transform.tag == "Anker")
                    {
                        //Cursorの位置からLengthの長さ分振り子運動する

                    }

                    else if(hit_list[i].transform.tag == "Wall")
                    {
                        //Cursorの位置にPlayerを移動させて停止させる
                        Vector2 pos = Camera.main.ScreenToWorldPoint(CursorPos);
                        player.transform.position = pos;
                        
                    }

                }
            }
        }

 
}
