using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthControlScript : MonoBehaviour
{
    public GameObject heart1, heart2, heart3, gameOver;
    public void Start()
    {
        SaveData.DoLoadData = true;
        SaveData.Loads();
    }

    public void show_healthbar() 
    {
        HealthReSet(); //(�켱�� �ӽ÷� �־���. ���߿� ���ְ� �ʱ⿡ �����ٶ� ���� ȣ�⿡�� ���)
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
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
        if(SaveData.health > 0)
            SaveData.health--;
        SaveData.Saves();

        Update_Show_Health();
    }

    public void health_increase()
    {
        SaveData.Loads();
        if(SaveData.health < 3)
            SaveData.health++;
        SaveData.Saves();

        Update_Show_Health();
    }

    void Update_Show_Health()
    {
        SaveData.Loads();
        switch (SaveData.health)
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

    public void Update()
    {
       
    }
    public void HealthReSet()
    {
        SaveData.Loads();
        SaveData.health = 3;
        SaveData.Saves();
    }

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}  //game control �� �ְ� �׾ȿ� ��ũ��Ʈ�� ��Ʈ 1 2 3 ���ӿ����� �־��� 