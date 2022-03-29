using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlScript : MonoBehaviour
{
    public GameObject heart1, heart2, heart3, gameOver;
    public bool start = false;
    public static int health;
    public void Start()
    {
        SaveData.DoLoadData = true;
        SaveData.Loads();
        health = SaveData.health;

        heart1.gameObject.SetActive(false);
        heart2.gameObject.SetActive(false); 
        heart3.gameObject.SetActive(false); 
        gameOver.gameObject.SetActive(false);
    }

    void healthbar() 
    {
        SaveData.health = 3 ;
        SaveData.Saves();

        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
    }
    private void FixedUpdate()
    {
        if(Day1_1.count == 74 && start == false)
        {
            start = true;
            healthbar();
        }

        else if(Day1_1.count ==  80){
            Debug.Log("123123");
            health--;
        }
    }

    public static void SaveHealth()
    {
        SaveData.Loads();
        SaveData.health = health;
        SaveData.Saves();
    }
    
    public void Update()
    {

        if (health > 3)
            health = 3;
        if (start == true)
        {

            switch (health)
            {
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
        //SaveData.Saves();
    }
    public void HealthReSet()
    {
        SaveData.Loads();
        SaveData.health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
        SaveData.Saves();

    }

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}  //game control 에 넣고 그안에 스크립트에 하트 1 2 3 게임오버를 넣어줌 