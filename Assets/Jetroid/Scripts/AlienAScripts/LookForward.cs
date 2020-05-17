﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookForward : MonoBehaviour
{
    public Transform sightStart, sightEnd;
    private bool collision;
    [SerializeField]
    private string layer = "Solid";
    [SerializeField]
    private bool needsCollision = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        collision = Physics2D.Linecast(sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer(layer));

        Debug.DrawLine(sightStart.position, sightEnd.position,Color.green);
        //Debug.Log("Collision is " + collision);
        if (collision == needsCollision)
        {
            transform.localScale = new Vector3(transform.localScale.x == 1 ? -1 : 1, 1f, 1f);
        }
    }
}
