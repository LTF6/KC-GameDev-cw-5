using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotAScript : MonoBehaviour
{
    private Rigidbody2D RB;
    public int paddleSpeed = 12;
    float playerInput;
    public GameObject HungerCat;
    public int x;
    // Start is called before the first frame update
    void Start()
    {
        RB = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {  
        playerInput = Input.GetAxis("Horizontal");
        RB.velocity = new Vector2(playerInput * paddleSpeed,0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
         // As7b 3lahm malhm da3y
        if(collision.gameObject == HungerCat){
            playerInput = Input.GetAxis("Horizontal");
            RB.velocity = new Vector2(playerInput * paddleSpeed % 2, 0);
            Debug.Log("Speed is reduced");
            x = 1;
        }else if(x == 1) {
            playerInput = Input.GetAxis("Horizontal");
            RB.velocity = new Vector2(playerInput * paddleSpeed % 2, 0);
            Debug.Log("Speed is reduced x 2");
            x = 2;
        }else if(x == 2) {
            playerInput = Input.GetAxis("Horizontal");
            RB.velocity = new Vector2(playerInput * paddleSpeed % 2, 0);
            Debug.Log("Speed is reduced x 3");
            x = 3;
        }else if(x == 3) {
            playerInput = Input.GetAxis("Horizontal");
            RB.velocity = new Vector2(playerInput * paddleSpeed % 2, 0);
            Debug.Log("Speed is reduced x 4");
            x = 4;
        }else if(x == 4) {
            playerInput = Input.GetAxis("Horizontal");
            RB.velocity = new Vector2(playerInput * paddleSpeed % 2, 0);
            Debug.Log("Speed is reduced x 5");
            x = 5;
        }else if(x == 5) {
            playerInput = Input.GetAxis("Horizontal");
            RB.velocity = new Vector2(playerInput * paddleSpeed % 6, 0);
            Debug.Log("Speed is reduced x 6");
            x = 5;
        }
    }

}
