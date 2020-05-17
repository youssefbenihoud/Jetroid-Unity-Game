using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpritesScript : MonoBehaviour
{

    [SerializeField]
    private Sprite[] sprites;
    [SerializeField]
    private int currentSprite = -1;

    private void Awake()
    {
        if (currentSprite < 0)
        {
            currentSprite = Random.Range(0, sprites.Length);

        }
        else if (currentSprite > sprites.Length)
        {
            currentSprite = sprites.Length;
        }

        GetComponent<SpriteRenderer>().sprite = sprites[currentSprite];
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
