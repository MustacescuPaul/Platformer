﻿using UnityEngine;
using System.Collections;

public class ButtonMovement : TouchManager
{
    public float jumpHeight = 0.0f;
    public float moveSpeed = 0.0f;
    public GUITexture buttonTexture = null; 
    public enum type { LeftButton, RightButton, JumpButton };
    public type buttonType;

    public GameObject playerObject = null;
    Rigidbody2D playerRigidbody = null;

    void Start ()
    {
        playerRigidbody = playerObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        TouchInput(buttonTexture);
    }

    void OnFirstTouchBegan()
    {
        switch (buttonType)
        { 
        case type.JumpButton:
                playerRigidbody.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
        break;
        }
    }

    void OnSecondTouchBegan()
    {
        switch (buttonType)
        {
            case type.JumpButton:
                playerRigidbody.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
                break;
        }
    }

    void OnFirstTouch()
    {
        switch (buttonType)
        {
           
            case type.LeftButton:
                playerObject.transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);
                break;
            case type.RightButton:
                playerObject.transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
                break;

        }
    }

    void OnSecondTouch()
    {
        switch (buttonType)
        {

            case type.LeftButton:
                playerObject.transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);
                break;
            case type.RightButton:
                playerObject.transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
                break;

        }
    }
}
