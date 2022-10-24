using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireBall : MonoBehaviour
{
    public float ballSpeed = 10;
    private bool limitR;
    private bool limitL;
    // Start is called before the first frame update
    void Start()
    {
        limitR = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (limitR == true)
        {
            transform.Translate(Vector3.left * ballSpeed * Time.deltaTime);
        }
        if(limitL == true)
        {
            transform.Translate(Vector3.right * ballSpeed * Time.deltaTime);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("MenuGameOver");
        }
        if(other.gameObject.CompareTag("LimitL"))
        {
            limitL = true;
            limitR = false;
        }
        else if(other.gameObject.CompareTag("LimitR"))
        {
            limitL = false;
            limitR = true;

        }

    }





}
