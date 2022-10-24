using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotateSpeedY = 300f;

    private float rotateInputY;


    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        rotateInputY = Input.GetAxis("Mouse Y");
        float angle = rotateInputY * rotateSpeedY * Time.deltaTime;
        transform.Rotate(Vector3.left * angle);
    }
}
