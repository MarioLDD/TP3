using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Shooting>().EnemyKilled();

            Destroy(collision.gameObject);
            Destroy(this.gameObject);


        }
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("MenuGameOver");
        }

    }
}
