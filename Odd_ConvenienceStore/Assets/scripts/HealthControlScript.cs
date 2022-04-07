using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthControlScript : MonoBehaviour
{
    public GameObject heart1, heart2, heart3, gameOver;
    private int health;

    public void Start()
    {
       
    }

    public void hide_healthbar()
    {
        heart1.gameObject.SetActive(false);
        heart2.gameObject.SetActive(false);
        heart3.gameObject.SetActive(false);
        gameOver.gameObject.SetActive(false);
    }

    public void health_decrease()
    {
        SaveData.Loads();
        if (health > 0)
            health--;
        SaveData.health = health;
        SaveData.Saves();

        Show_Health();
    }

    public void health_increase()
    {
        SaveData.Loads();
        if (health < 3)
            health++;
        SaveData.health = health;
        SaveData.Saves();

        Show_Health();
    }

    public void Show_Health()
    {
        //SaveData.Loads();
        //health = SaveData.health;
        //Debug.Log(SaveData.health);

        switch (health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);

                Time.timeScale = 0;
                break;
        }
    }

    public void Update()
    {
       
    }
    public void HealthReSet()
    {
        SaveData.Loads();
        health = 3;
        SaveData.health = health;
        SaveData.Saves();
    }

    public void Awake()
    {
        SaveData.DoLoadData = true;
        health = SaveData.health;
        DontDestroyOnLoad(gameObject);
    }
}  //game control 에 넣고 그안에 스크립트에 하트 1 2 3 게임오버를 넣어줌 