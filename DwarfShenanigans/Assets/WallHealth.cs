using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth; 
    
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth < 0)
        {
            Destroy(gameObject);
        }
    }


    public void TakeDamage(int damage)
    { 
        currentHealth -= damage;
    }
}
