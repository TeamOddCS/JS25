using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthControlScript : MonoBehaviour
{
    public GameObject heart, heart1, heart2, heart3, gameOver;
    private static int health;
    private static string JSName, nickname, reason;
    

    public void Start()
    {
       
    }

    public void hide_healthbar()
    {
        heart.gameObject.SetActive(false);
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
                reason = "쓰러졌습니다.";
                break;
            case 1:
                reason = "빤스런 했습니다.";
                break;
            case 2:
                reason = "손님의 뺨을 쳐 경찰서에 잡혀갔습니다.";
                break;
            default:
                Debug.Log("예외처리");
                break;
        }

        switch(rName)
        {
            case 0:
                if (JSName == "JS1")
                    nickname = "무지성 ‘담배줘’ 아저씨";
                else if (JSName == "JS2")
                    nickname = "반말과 꼰대와 명령이 콜라보된 아저씨";
                else if (JSName == "JS3")
                    nickname = "폐기루팡 할아버지";
                else if (JSName == "JS4")
                    nickname = "폐기루팡 아지매";
                else if (JSName == "JS5")
                    nickname = "극한의 서비스충";
                else if (JSName == "JS6")
                    nickname = "누구보다 쎈";
                else if (JSName == "JS7")
                    nickname = "누구보다 강한 문신남";
                else if (JSName == "JS8")
                    nickname = "딜레이 있는 여자";
                else if (JSName == "JS9")
                    nickname = "대화를 요구하는 독거노인";
                else if (JSName == "IB1")
                    nickname = "예민보스";
                else
                    nickname = "error";
                break;

            case 1:
                if (JSName == "JS1")
                    nickname = "꼴초 담배충 아저씨";
                else if (JSName == "JS2")
                    nickname = "미친 취객";
                else if (JSName == "JS3")
                    nickname = "냄새나는 노숙자";
                else if (JSName == "JS4")
                    nickname = "억까공병 아줌마";
                else if (JSName == "JS5")
                    nickname = "폰사장친구방패";
                else if (JSName == "JS6")
                    nickname = "술.담배 협박 여고생";
                else if (JSName == "JS7")
                    nickname = "허세 강력한 남자";
                else if (JSName == "JS8")
                    nickname = "미정";
                else if (JSName == "JS9")
                    nickname = "열등감 100배 노인";
                else if (JSName == "IB1")
                    nickname = "프로불평충";
                else
                    nickname = "error";
                break;

            default:
                Debug.Log("예외처리");
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
                heart.gameObject.SetActive(true);
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                heart.gameObject.SetActive(true);
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart.gameObject.SetActive(true);
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            case 0:
                heart.gameObject.SetActive(true);
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                GameOver();
                Debug.Log(nickname + "(으)로 인한 극도의 스트레스로 " + reason);
                Time.timeScale = 0;
                break;
        }
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