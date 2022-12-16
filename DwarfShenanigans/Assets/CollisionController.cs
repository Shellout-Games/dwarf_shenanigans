using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public WallHealth wallhealth;
    public int damage = 3;

    void Start()
    { 
    
    }

    void Update()
    { 
    
    }

    private void OnCollisionEnter2D(Collision2d collision)
    {
        if (collision.gameObject.tag == "BreakWall")
        {
            wallHealth.TakeDamage(damage);
        }
            
    }
}
