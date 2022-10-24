using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject gameover;
    public GameObject victory;
    public GameObject menuInicial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Victory()
    {
        menuInicial.SetActive(false);
        victory.SetActive(true);

    }

    public void Reset()
    {
        victory.SetActive(false);
        gameover.SetActive(false);
        menuInicial.SetActive(true);
        Debug.Log("reset");
    }


    public void GameOver()
    {
        menuInicial.SetActive(false);
        gameover.SetActive(true);
    }


    public void Exit()
    {
        Application.Quit();
        Debug.Log("exit");

    }




}
