using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
public class PlayerController : MonoBehaviour
{
    //[Header("Behaviour Options")]

    [SerializeField]
    private float speed = 10.0f;

    [SerializeField]
    private float jumpForce = 250.0f;

    [SerializeField]
    private XRNode controllerNode = XRNode.LeftHand;

    [SerializeField]
    private bool checkForGroundOnJump = true;

    [SerializeField]
    private Vector3 capsuleCenter = new Vector3(0,1,0);
    
    [SerializeField]
    private float capsuleRadius = 0.3f;

    [SerializeField]
    private float capsuleHeight = 1.6f;

    [SerializeField]
    private CapsuleDirection capsuleDirection = CapsuleDirection.YAxis;

    private InputDevice controller;

    private bool isGrounded;

    private bool buttonPressed;

    private Rigidbody rigidBodyComponent;

    private CapsuleCollider capsuleCollider;

    private List<InputDevice> devices = new List<InputDevice>();

    public enum CapsuleDirection
    {
        XAxis,
        YAxis,
        ZAxis

    }

    private void OnEnable()
    {
        rigidBodyComponent = GetComponent<Rigidbody>();
        capsuleCollider = GetComponent<CapsuleCollider>();

        rigidBodyComponent.constraints = RigidbodyConstraints.FreezeRotation;
        capsuleCollider.direction = (int)capsuleDirection;
        capsuleCollider.radius = capsuleRadius;
        capsuleCollider.center = capsuleCenter;
        capsuleCollider.height = capsuleHeight;
    }
    // Start is called before the first frame update
    void Start()
    {
        GetDevice();
    }
    private void GetDevice()
    {
        InputDevices.GetDevicesAtXRNode(controllerNode, devices);
        controller = devices.FirstOrDefault();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
