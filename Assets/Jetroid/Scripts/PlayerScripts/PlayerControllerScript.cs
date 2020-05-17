using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{

    private Vector2 moving = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DoMoving();
    }


    private void DoMoving()
    {
        moving.x = moving.y = 0;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            moving.x = 1f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            moving.x = -1f;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            moving.y = 1f;

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            moving.y = -1f;
        }
    }


    public Vector2 GetMoving()
    {
        return moving;
    }





}//class
