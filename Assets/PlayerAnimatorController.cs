using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerAnimatorController : MonoBehaviour
{
    RigidbodyFirstPersonController myRigidBodyController;
    Rigidbody myRig;
    Animator playerAnimator;

    private void Start()
    {
        myRigidBodyController = GetComponent<RigidbodyFirstPersonController>();
        myRig = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
    }


    private void FixedUpdate()
    {
        if(myRig.velocity.magnitude > 1 && myRigidBodyController.Grounded)
        {
            playerAnimator.SetBool("isWalking", true);
        }
        else
        {
            playerAnimator.SetBool("isWalking", false);
        }
    }

}
