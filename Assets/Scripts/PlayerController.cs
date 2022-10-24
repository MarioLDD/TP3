using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 8f;
    private float forwardInput;
    private float horizontalInput;
    public float rotateSpeed = 300f;
    private float rotateInputX;
    public Rigidbody rb;
    public float forceJump = 6;
    bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
        grounded = true;
        transform.Rotate(0 , 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0, forwardInput);
        direction = Vector3.ClampMagnitude(direction, 1) * speed * Time.deltaTime;
        transform.Translate(direction);

        rotateInputX = Input.GetAxis("Mouse X");
        float angle = rotateInputX * rotateSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up * angle);

        if (Input.GetKeyDown(KeyCode.Space) && grounded == true)
        {
            rb.AddForce(0, forceJump, 0, ForceMode.Impulse);
            grounded = false;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }

    }
}






