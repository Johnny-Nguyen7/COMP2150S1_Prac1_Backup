using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Mole : MonoBehaviour
{
    public Color colour;
    // Start is called before the first frame update
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>(); 
        sprite.color = colour;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
