using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public  PlayerController controller;
    public float sanicRun = 40f;  //speed of runner
    float horizontalMove = 0f;
    bool downCrouch = false;
    bool verticalJump = false;

    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update() {
        horizontalMove = Input.GetAxisRaw("Horizontal") * sanicRun;
        if (Input.GetButtonDown("Jump"))
        {
            verticalJump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            downCrouch =  true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            downCrouch = false;
        }
    }
    void FixedUpdate() { //move character
        controller.Move(horizontalMove * Time.fixedDeltaTime,downCrouch,verticalJump); //Time.deltaTime move same amount no matter how many times function is called. 
        verticalJump = false;
        
        
    }
    
}
