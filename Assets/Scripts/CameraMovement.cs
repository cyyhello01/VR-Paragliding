using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //public Transform target;
    public Camera camera1;
    public float moveSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 move = new Vector3(moveSpeed,0,0);
            camera1.transform.position += move; 
        }
    }
}
