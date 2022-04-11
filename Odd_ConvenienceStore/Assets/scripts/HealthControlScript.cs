using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthControlScript : MonoBehaviour
{
    public GameObject heart1, heart2, heart3, gameOver;
    private static int health;
    private static string JSName, nickname, reason;
    //public Blink blink;

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
        JSName = SaveData.JSName;
        Debug.Log(JSName);
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

    public void GameOver()
    {
        int rName = Random.Range(0, 2);
        int rReason = Random.Range(0, 3);
        
        switch(rReason)
        {
            case 0:
                reason = "���������ϴ�.";
                break;
            case 1:
                reason = "������ �߽��ϴ�.";
                break;
            case 2:
                reason = "�մ��� ���� �� �������� ���������ϴ�.";
                break;
            default:
                Debug.Log("����ó��");
                break;
        }

        switch(rName)
        {
            case 0:
                if (JSName == "JS1")
                    nickname = "������ ������࡯ ������";
                else if (JSName == "JS2")
                    nickname = "�ݸ��� ����� ����� �ݶ󺸵� ������";
                else if (JSName == "JS3")
                    nickname = "������ �Ҿƹ���";
                else if (JSName == "JS4")
                    nickname = "������ ������";
                else if (JSName == "JS5")
                    nickname = "������ ������";
                else if (JSName == "JS6")
                    nickname = "�������� ��";
                else if (JSName == "JS7")
                    nickname = "�������� ���� ���ų�";
                else if (JSName == "JS8")
                    nickname = "������ �ִ� ����";
                else if (JSName == "JS9")
                    nickname = "��ȭ�� �䱸�ϴ� ���ų���";
                else if (JSName == "IB1")
                    nickname = "���κ���";
                else
                    nickname = "error";
                break;

            case 1:
                if (JSName == "JS1")
                    nickname = "���� ����� ������";
                else if (JSName == "JS2")
                    nickname = "��ģ �밴";
                else if (JSName == "JS3")
                    nickname = "�������� �����";
                else if (JSName == "JS4")
                    nickname = "������ ���ܸ�";
                else if (JSName == "JS5")
                    nickname = "������ģ������";
                else if (JSName == "JS6")
                    nickname = "��.��� ���� �����";
                else if (JSName == "JS7")
                    nickname = "�㼼 ������ ����";
                else if (JSName == "JS8")
                    nickname = "����";
                else if (JSName == "JS9")
                    nickname = "��� 100�� ����";
                else if (JSName == "IB1")
                    nickname = "���κ�����";
                else
                    nickname = "error";
                break;

            default:
                Debug.Log("����ó��");
                break;
        }
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
                GameOver();
                Debug.Log(nickname + "(��)�� ���� �ص��� ��Ʈ������ " + reason);
                Time.timeScale = 0;
                break;
        }
    }

    public void Update()
    {/*
        if (Day1_1.count == 75)
        {
            StartCoroutine(BlinkGameObject(heart1, 5, 10));
        }
        if (Day1_1.count == 75)
        {
            StartCoroutine(BlinkGameObject(heart2, 5, 10));
        }
        if (Day1_1.count == 75)
        {
            StartCoroutine(BlinkGameObject(heart3, 5, 10));
        } */
    }
    /*public IEnumerator BlinkGameObject(GameObject gameObject, int numBlinks, float seconds)
    {
        // In this method it is assumed that your game object has a SpriteRenderer component attached to it
        SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
        // disable animation if any animation is attached to the game object
        //      Animator animator = gameObject.GetComponent<Animator>();
        //      animator.enabled = false; // stop animation for a while
        for (int i = 0; i < numBlinks * 2; i++)
        {
            //toggle renderer
            renderer.enabled = !renderer.enabled;
            //wait for a bit
            yield return new WaitForSeconds(seconds);
        }
        //make sure renderer is enabled when we exit
        renderer.enabled = true;
        //    animator.enabled = true; // enable animation again, if it was disabled before
    }*/
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
}  //game control �� �ְ� �׾ȿ� ��ũ��Ʈ�� ��Ʈ 1 2 3 ���ӿ����� �־��� 