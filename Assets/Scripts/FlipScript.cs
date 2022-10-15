using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipScript : MonoBehaviour
{
    private SpriteRenderer sprite;
    //private Vector2 inputDirection;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        SpriteFlip();
    }

    private void FixedUpdate()
    {
        //float horizontal = Input.GetAxisRaw("Horizontal");
    }

    private void SpriteFlip()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            sprite.flipX = true;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            sprite.flipX = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Hat")
        {
            Debug.Log("Hat obtained!!");
            sprite.enabled = true;
        }
    }
}
