using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private DebrisScript debris;
    [SerializeField]
    private int totalDebris = 10;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Deadly")
        {
            OnExplode();
        }
    }


    private void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.tag == "Deadly")
        {
            OnExplode();
        }
    }

    private void OnExplode()
    {
        Transform t = transform;
        for (int i = 0; i < totalDebris; i++)
        {
            t.TransformPoint(0, -1000, 0);
            var clone = Instantiate(debris, t.position, Quaternion.identity) as DebrisScript;
            var body2D = clone.GetComponent<Rigidbody2D>();
            body2D.AddForce(Vector3.right * Random.Range(-1000, 1000));
            body2D.AddForce(Vector3.up * Random.Range(500, 2000));

        }



        Destroy(gameObject);
    }
}
