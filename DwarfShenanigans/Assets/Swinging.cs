using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swinging : MonoBehaviour
{
    public Animator animator;
    private bool isSwinging = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if player clicks the animation plays
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            isSwinging = true;
        }
        else
        {
            isSwinging = false;
        }
        animator.SetBool("isSwinging", isSwinging);



    }
}
