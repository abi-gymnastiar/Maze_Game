using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillationScript : MonoBehaviour
{
    [SerializeField] public float delta = 1.5f;  // Amount to move left and right from the start point
    [SerializeField] public float speed = 2.0f;
    private Vector3 startPos;
    [SerializeField] private int yak = 1;
    private SpriteRenderer sprite;

    void Start()
    {
        startPos = transform.position;
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        //Vector3 v = startPos;
        //v.x += delta * Mathf.Sin(Time.time * speed);
        //transform.position = v;
    }

    private void FixedUpdate()
    {
        if (yak == 1)
        {
            Vector3 v = startPos;
            v.x += delta * Mathf.Sin(Time.time * speed);
            transform.position = v;
        }
        else if(yak == 2)
        {
            Vector3 v = startPos;
            v.y += delta * Mathf.Sin(Time.time * speed);
            transform.position = v;
        }
    }
}
