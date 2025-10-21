using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isInvincible = false;
    bool bPressed = false;
    float comboWindow = 0.5f;
    float comboTimer = 0f;

    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;

    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boostSpeed = 30f; 
    [SerializeField] float baseSpeed = 20f; 

    bool canMove = true;

    void Start()
    {
       
        rb2d = GetComponent<Rigidbody2D>();

      
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            RespondToBoost();
        }

        // B được nhấn → bắt đầu combo
        if (Input.GetKeyDown(KeyCode.B))
        {
            bPressed = true;
            comboTimer = comboWindow;
        }

        // Nếu đang trong combo window và T được nhấn → bật/tắt bất tử
        if (bPressed && Input.GetKeyDown(KeyCode.T))
        {
            isInvincible = !isInvincible;
            bPressed = false;

            if (isInvincible)
                Debug.Log(" Invincibility ON");
            else
                Debug.Log(" Invincibility OFF");
        }

        // Đếm ngược thời gian combo
        if (bPressed)
        {
            comboTimer -= Time.deltaTime;
            if (comboTimer <= 0f)
            {
                bPressed = false;
            }
        }
    }

    public void DisableControls()
    {
      
        canMove = false;
    }

    void RotatePlayer()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
          
            rb2d.AddTorque(torqueAmount);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
         
            rb2d.AddTorque(-torqueAmount);
        }
    }

    void RespondToBoost()
    {
       
        if (Input.GetKey(KeyCode.UpArrow))
        {
          
            surfaceEffector2D.speed = boostSpeed;
        }

        else
        {
      
            surfaceEffector2D.speed = baseSpeed;
        }       
    }
}
