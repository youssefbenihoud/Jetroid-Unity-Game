using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatEffect : MonoBehaviour
{
    private float startY = 0f;
    private float duration = 1f;
    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        startY = rectTransform.anchoredPosition.y;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var newY = startY + (startY + Mathf.Cos(Time.time / duration * 2)) / .1f;
        Vector2 temp = rectTransform.anchoredPosition;
        temp.y = newY;
        rectTransform.anchoredPosition = temp;
    }
}
