using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatescript : MonoBehaviour
{
    private float rot = 180f; //base rotation
	
	//THIS SCRIPT IS UNUSED IN THE FINAL PROJECT, WAS FOR A DEMO

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() //check for input and rotate
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            rot+=0.75f;
        if (Input.GetKey(KeyCode.RightArrow))
            rot-=0.75f;

        Vector3 rotv = new Vector3(0.0f, rot, 0.0f);
        transform.rotation = Quaternion.Euler(rotv);
    }
}
