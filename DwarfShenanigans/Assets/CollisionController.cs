using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public WallHealth wallHealth;
    public int damage = 3;

    void Start()
    { 
    
    }

    void Update()
    { 
    
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BreakWall")
        {
            collision.gameObject.GetComponent<WallHealth>().TakeDamage(damage);
        }
            
    }
}
