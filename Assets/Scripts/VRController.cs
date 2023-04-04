using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRController : MonoBehaviour
{
    public Camera camera;
    public InputDevice rightController;
    public InputDevice leftController;

    //private Vector3 leftPosition;
    //private Vector3 rightPosition;
    //private Vector3 maxPosition;

    //private Vector3 leftRotation;
    //private Vector3 rightRotation;
    //private Vector3 maxRotation;

    //private Vector3 leftVelocity;
    //private Vector3 rightVeloity;


    // Start is called before the first frame update
    void Start()
    {
        rightController = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);//to access right controller
        leftController = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);//to access left controller
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rotation;
        if (rightController.TryGetFeatureValue(CommonUsages.deviceRotation, out  rotation))
        {
            Debug.Log("right contol moved");
            //do something
        }

        if (leftController.TryGetFeatureValue(CommonUsages.deviceRotation, out rotation))
        {
            Debug.Log("left contol moved");
        }


        //---Launching---
        //run forward


        //---In the mid air---
        //hand brakes - to change speed & direction of flight
        //If you want to turn to the right, pull on the right control and release pressure on the left.
        //This makes the right side of the wing fly slower and the left faster. 
        //so u r turning right

        //-To slow down speed
        //if (left controller.position move left && pull down)
        //speed(20) = leftvelocity(high = slow down fast) 
        //  camera.position (paraglider) will turn their position to the left gradually

        //if (right controller.position move right && pull down)
        //  camera.position (paraglider) will turn their position to the right gradually

        //-To release pressure
        //if (left controller.position move left && pull up)
        //  camera.position (paraglider) will turn their position to the right gradually

        //if (right controller.position move right && pull up)
        //  camera.position (paraglider) will turn their position to the left gradually

    }
}
