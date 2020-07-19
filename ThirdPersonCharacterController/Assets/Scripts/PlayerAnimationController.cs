using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{

    public Animator playerAnimator;
    public ThirdPersonMovement character;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerAnimator.SetFloat("XAxis", character.horizontal);
        playerAnimator.SetFloat("ZAxis", character.vertical);

        if (character.horizontal != 0 || character.vertical !=0)
        {
            playerAnimator.SetBool("IsMoving", true);
        }
        else if(playerAnimator.GetBool("IsMoving")==true)
        {
            playerAnimator.SetBool("IsMoving", false);
        }

        if (Input.GetButtonDown("Jump"))
        {
            playerAnimator.SetBool("IsJumping", true);
        }

        if(Input.GetButtonDown("Sprint"))
        {
            playerAnimator.SetBool("IsSprinting", true);
        }
        if(Input.GetButtonUp("Sprint"))
        {
            playerAnimator.SetBool("IsSprinting", false);
        }
        
    }
}
