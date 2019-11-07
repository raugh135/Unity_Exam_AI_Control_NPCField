using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour {
    [Header("對話")]
    public string Say = "OMG";
    public string SaySpeed = "0.5";

    [Header("任務")]
    public bool Complete;
    public string BateryFinish = "5";
    public string Batery = "0";

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
