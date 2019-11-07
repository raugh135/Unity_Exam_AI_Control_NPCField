using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    [Range(0 , 1000) , Header("速度")]
    public int speed = 50;

    [Range(0, 1000) , Header("跳躍")]
    public int jump = 100;

    [Header("是否在地上")]
    public bool isGround = true;

    private Rigidbody r3d;

	// Use this for initialization
	void Start () {

        r3d = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGround = true;
    }

    private void FixedUpdate()
    {
        Jump();
        Walk();
    }

    /// <summary>
    /// 走路
    /// </summary>
    private void Walk()
    {
        r3d.AddForce(new Vector3(speed * Input.GetAxis("Horizontal"), 0 , speed * Input.GetAxis("Vertical")));
    }

    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            isGround = false;
            r3d.AddForce(new Vector3(0, jump, 0));
        }
        }
    }

