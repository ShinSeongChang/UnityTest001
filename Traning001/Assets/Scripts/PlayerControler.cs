using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerControler : MonoBehaviour
{
    public Rigidbody playerRigid = default;
    public float speed = default;
    // Start is called before the first frame update
    void Start()
    {
        playerRigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKey(KeyCode.UpArrow) == true)
        //{
        //    playerRigid.AddForce(0f, 0f, speed);
        //}

        //if(Input.GetKey(KeyCode.DownArrow) == true)
        //{
        //    playerRigid.AddForce(0f, 0f, -speed);
        //}

        //if (Input.GetKey(KeyCode.RightArrow) == true)
        //{
        //    playerRigid.AddForce(speed, 0f, 0f);
        //}

        //if (Input.GetKey(KeyCode.LeftArrow) == true)
        //{
        //    playerRigid.AddForce(-speed, 0f, 0f);
        //}

        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");
        float yInput = Input.GetAxis("Jump");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;
        float ySpeed = yInput * speed;


        Vector3 newVelocity = new Vector3 (xSpeed, ySpeed, zSpeed);
        playerRigid.velocity = newVelocity;
    }

    public void Die()
    {
        gameObject.SetActive (false);

        GameManager gameManager = FindObjectOfType<GameManager> ();

        gameManager.EndGame();
    }
}
