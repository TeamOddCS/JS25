using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour
{
    public GameObject heart1, heart2, heart3, gameOver;
    public static int health;

    private void Start() //�ٷ����� SetActive �� ��Ȱ������µ� �ֻ���ִ�..? 
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
        //OnEnable �̿��ؾߵǳ� ������Ʈ�� Ȱ��ȭ�Ǵµ��ȸ� ȣ��ȴٴµ� 
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
}  //game control �� �ְ� �׾ȿ� ��ũ��Ʈ�� ��Ʈ 1 2 3 ���ӿ����� �־��� 