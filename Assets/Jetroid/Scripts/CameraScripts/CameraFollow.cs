using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private GameObject target;
    private float scale = 4f;
    private Transform t;


    private void Awake()
    {
        var cam = GetComponent<Camera>();
        cam.orthographicSize = (Screen.height / 2f) / scale;
    }
    // Start is called before the first frame update
    void Start()
    {
        t = target.transform;
    }

    // Update is called once per frame
    void Update()
    {
        followTarget();
    }



    private void followTarget()
    {
        if (target != null)
        {
            var temp = transform.position;
            temp.x = t.position.x;
            temp.y = t.position.y;
            transform.position = temp;
        }
    }











}//class
