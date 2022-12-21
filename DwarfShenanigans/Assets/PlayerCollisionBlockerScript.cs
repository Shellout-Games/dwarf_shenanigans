using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionBlockerScript : MonoBehaviour
{
    [SerializeField] private BoxCollider2D playerCollider;
    [SerializeField] private BoxCollider2D playerColliderBlocker;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreCollision(playerCollider, playerColliderBlocker, true);
    }
}

 
