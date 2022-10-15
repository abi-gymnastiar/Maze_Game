using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollide : MonoBehaviour
{
    //GameObject gameObject;

    private void Start()
    {
        //gameObject = GetComponent<GameObject>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Item Gone");
            Destroy(this.gameObject);
        }
    }

}
