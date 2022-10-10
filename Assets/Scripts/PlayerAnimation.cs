using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    private int spriteIndex;

    public float animationSpeed = 0.23f;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), animationSpeed, animationSpeed);
    }

    private void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            spriteRenderer.flipX = true;
        }
        else if (Input.GetKeyDown("d"))
        {
            spriteRenderer.flipX = false;
        }

    }

    private void AnimateSprite()
    {
        spriteIndex++;

        if (spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }

        spriteRenderer.sprite = sprites[spriteIndex];


    }
}
