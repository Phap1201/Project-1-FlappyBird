using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float JumForce;
    public Rigidbody2D Rigidbody;

    // Update is called once per frame
    void Update()
    {
        bool isJump = Input.GetKeyDown(KeyCode.Space);
        if (isJump)
        {
            Jum();
        }
     
    }
    void Jum()
    {
        Rigidbody.velocity += Vector2.up * JumForce;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
       if(!other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game Over");
        }
    }
}
