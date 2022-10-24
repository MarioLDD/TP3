using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Shooting : MonoBehaviour

{
    public Transform spawnPosition;
    public GameObject bulletPrefab;
    public float bulletForce = 50;
    public int totalEnemy;
    public Text killCountUI;
    public int killCount;

    void Start()
    {
        totalEnemy = GameObject.FindGameObjectsWithTag("Enemy").Length;
        killCountUI.text = "Kills: " + killCount.ToString() + " / " + totalEnemy.ToString();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletClone = Instantiate(bulletPrefab, spawnPosition.position, spawnPosition.rotation);
            Rigidbody rb = bulletClone.GetComponent<Rigidbody>();
            rb.AddRelativeForce(Vector3.forward * bulletForce, ForceMode.Impulse);
        }
    }

    public void EnemyKilled()
    {
        Debug.Log("Enemy Killed");
        killCount++;
        killCountUI.text = "Kills: " + killCount.ToString() + " / " + totalEnemy.ToString();

        if (killCount == totalEnemy)
        {
            SceneManager.LoadScene("MenuVictory");
        }
    }



}

