using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Pipe : MonoBehaviour
{
    public float Speed;
    public int Score;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveMent();
    }
    void MoveMent()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime, 0);   
        if(transform.position.x<-8f)
        {
            Destroy(gameObject);
        }
       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            GameManager.instance.AddScore(Score);
            
        }    
    }

}
