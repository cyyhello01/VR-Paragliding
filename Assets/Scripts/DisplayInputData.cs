using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using TMPro;

[RequireComponent(typeof(InputData))]
public class DisplayInputData : MonoBehaviour
{
    public GameObject cam;
    public TextMeshProUGUI leftScoreDisplay;
    public TextMeshProUGUI rightScoreDisplay;

    private InputData inputData;
    private float leftMaxScore = 0f;
    private float rightMaxScore = 0f;


    // Start is called before the first frame update
    void Start()
    {
        inputData= GetComponent<InputData>();
        //Camera cam1 = cam.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //'deviceVelocity' is the input data we get from left controller, and stored it into vector3
        //device velocity = one of the data inputs
        //can replace it with other data inputs, ex: position, rotation
        if (inputData.leftController.TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 leftVelocity))
        {
            Debug.Log("left controller is moving");
            leftMaxScore = Mathf.Max(leftVelocity.magnitude, leftMaxScore); //left velocity larger than left max score? return the largest value
            leftScoreDisplay.text = leftMaxScore.ToString("F2");//second decimal point
            if (leftVelocity.magnitude > 0)
            {
                Debug.Log("move cam position");
                cam.transform.position += leftVelocity;
              
            }
        }
        if (inputData.rightController.TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 rightVelocity))
        {
            Debug.Log("right controller is moving");
            leftMaxScore = Mathf.Max(rightVelocity.magnitude, rightMaxScore);
            rightScoreDisplay.text = rightMaxScore.ToString("F2");
        }

       

    }
}
