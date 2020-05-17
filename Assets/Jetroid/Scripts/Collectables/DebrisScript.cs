using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisScript : MonoBehaviour
{
    private SpriteRenderer renderer;
    private Color start;
    private Color end;
    private float t = 0f;

    private void Awake()
    {
        renderer = GetComponent<SpriteRenderer>();
        start = renderer.color;
        end = new Color(start.r, start.g, start.b, 0f);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        renderer.material.color = Color.Lerp(start, end, t/2);

        if(renderer.material.color.a <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
