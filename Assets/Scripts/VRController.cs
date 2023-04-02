using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRController : MonoBehaviour
{
    public InputDevice targetDevice;
    public InputDevice targetDevice2;

    // Start is called before the first frame update
    void Start()
    {
        targetDevice = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
        targetDevice2 = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rotation;
        if (targetDevice.TryGetFeatureValue(CommonUsages.deviceRotation, out rotation))
        {
            Debug.Log("right contol moved");
            //do something
        }

        if (targetDevice2.TryGetFeatureValue(CommonUsages.deviceRotation, out rotation))
        {
            Debug.Log("left contol moved");
        }
    }
}
