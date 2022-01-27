using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour
{
    public GameObject heart1, heart2, heart3, gameOver;
    public static int health;

    private void Start() //바로전에 SetActive 를 비활성해줬는데 왜살아있니..? 
    {
        health = 3;
        //heart1.gameObject.SetActive(false);
        //heart2.gameObject.SetActive(false);
        //heart3.gameObject.SetActive(false);
        //heart1.SetActive(false);
        //heart2.SetActive(false);
        //heart3.SetActive(false);
        //gameOver.gameObject.SetActive(false);
    }

    private void Update()
    {
        //heart1.gameObject.SetActive(false);
        //heart2.gameObject.SetActive(false);
        //heart3.gameObject.SetActive(false);
        //gameOver.gameObject.SetActive(false);
        //OnEnable 이용해야되나 오브젝트가 활성화되는동안만 호출된다는데 
        if (health > 3)
            health = 3;

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

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}  //game control 에 넣고 그안에 스크립트에 하트 1 2 3 게임오버를 넣어줌 