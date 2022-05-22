using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthControlScript : MonoBehaviour
{
    public GameObject heart1, heart2, heart3, gameOver;
    public GameObject endingTextB, canvas, oriGraphic, failGraphic, lobbyBtn, reGameBtn;
    public Text endingText, lobbyText, reGameText;
    public Camera Camera;
    private static int health;
    private static string JSName, nickname, reason;
    private Vector2 mousePos;
    //public Blink blink;

    public void Start()
    {
        endingText.enabled = false;
        lobbyText.gameObject.SetActive(false);
        reGameText.gameObject.SetActive(false);
        endingTextB.SetActive(false);
        failGraphic.SetActive(false);
        lobbyBtn.SetActive(false);
        reGameBtn.SetActive(false);
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
                Invoke("ShowEnding", 0.1f);
                break;
        }
    }

    public void ShowEnding()
    {
        canvas.SetActive(false);
        oriGraphic.SetActive(false);
        endingTextB.SetActive(true);
        failGraphic.SetActive(true);
        lobbyBtn.SetActive(true);
        reGameBtn.SetActive(true);
        endingText.text = nickname + "(으)로 인한\n극도의 스트레스로\n" + reason;
        endingText.enabled = true;
        lobbyText.gameObject.SetActive(true);
        reGameText.gameObject.SetActive(true);
        Debug.Log(nickname + "(으)로 인한 극도의 스트레스로 " + reason);
        //Time.timeScale = 0;
    }

    public void goToLobby()
    {
        SaveData.Loads();
        SaveData.TempCount = 0;
        SaveData.TempScene = "Day0";
        SaveData.retry = true;
        SaveData.Saves();
        SceneManager.LoadScene("Title");

    }

    public void reGame()
    {
        SaveData.Loads();
        health = 1;
        SaveData.health = health;
        SaveData.Saves();

        if (SaveData.reGameStart == "Day0")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            Day0_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "Day1-1")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            Day1_1_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "Day1-3")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            Day1_3_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "Day2-1")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            Day2_1_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "Day2-3")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            Day2_3_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "Day2-F")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            Day2_F_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "Day3-1")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            Day3_1_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "Day3-3")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            Day3_3_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "Day3-F")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            Day3_F_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "Day4-1")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            Day4_1_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "Day4-2")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            Day4_2_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "Day4-3")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            Day4_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "Day4-F")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            Day4_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "Day5-1")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            Day5_1_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "Day5-3")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            Day5_3_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "Day6-1")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            Day6_1_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "Day6-F")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            Day6_F_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "Day7-1")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            Day7_1_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "Day7-F")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            Day7_F_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "JinSang1_1")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            JS1_1_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "JinSang2_1")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            JS2_1_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "JinSang2_2")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            JS2_2_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "JinSang2_3")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            JS2_3_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "JinSang3_1" || SaveData.reGameStart == "JinSang3_2" || SaveData.reGameStart == "JinSang3_3")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            JS3_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "JinSang4_1" || SaveData.reGameStart == "JinSang4_2" || SaveData.reGameStart == "JinSang4_3" || SaveData.reGameStart == "JinSang4_4")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            JS4_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "JinSang5_1")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            JS5_1_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "JinSang6_1")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            JS6_1_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "JinSang6_2")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            JS6_2_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "JinSang7_1")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            JS7_1_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "JinSang7_2")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            JS7_2_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "JinSang8_1")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            JS8_1_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "JinSang8_2")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            JS8_2_C.count = SaveData.reGameChoice;
        }

        if (SaveData.reGameStart == "JinSang8_3")
        {
            SaveData.TempCount = SaveData.reGame - 1;
            JS8_3_C.count = SaveData.reGameChoice;
        }

        SceneManager.LoadScene(SaveData.reGameStart);

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
}  //game control 에 넣고 그안에 스크립트에 하트 1 2 3 게임오버를 넣어줌 