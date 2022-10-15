using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private BoxCollider2D boxCollider;
    private Vector2 inputDirection;
    [SerializeField] public float playerSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        SpriteFlip();
        CheatKeys();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        inputDirection = new Vector2(horizontal, vertical).normalized;
        rb.velocity = inputDirection * playerSpeed;
    }

    private void SpriteFlip()
    {
        if(inputDirection.x < 0)
        {
            sprite.flipX = false;
        }
        else if(inputDirection.x > 0)
        {
            sprite.flipX = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Item")
        {
            Debug.Log("Sushi!!!");
            playerSpeed += 3;
        }
    }

    void CheatKeys()
    {
        //speed boost
        if (Input.GetKeyDown(KeyCode.O))
            playerSpeed += 3;
        if (Input.GetKeyDown(KeyCode.P))
            playerSpeed -= 3;

        //collider off
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (boxCollider.enabled == true)
                boxCollider.enabled = false;
            else if (boxCollider == false)
                boxCollider.enabled = true;
        }

        //next level
        if (Input.GetKeyDown(KeyCode.Period))
        {
            //int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
