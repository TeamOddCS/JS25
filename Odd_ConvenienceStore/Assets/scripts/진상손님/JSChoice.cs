using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JSChoice : MonoBehaviour
{
    private int random_num = -1;
    private static int last_num = -1;
    private static int check_D2 = 0;
    private static int check_D3 = 0;
    private static int check_D5 = 0;

    // Start is called before the first frame update
    void Start()
    {
        SaveData.DoChangeData = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Check_Day()
    {
        if (SaveData.LastScene.Equals("D1"))
            SceneManager.LoadScene("Day1-3");
        if (SaveData.LastScene.Equals("D2"))
        {
            Debug.Log("check_D2 : " + check_D2);
            if (check_D2 == 1)
                SceneManager.LoadScene("Day2-3");
            else
            {
                check_D2++;
                D2_JSChoice();
            }     
        }     
        if (SaveData.LastScene.Equals("D3"))
        {
            if(check_D3 == 1)
                SceneManager.LoadScene("Day3-3");
            else
            {
                check_D3++;
                //Debug.Log("check_D3 : " + check_D3);
                D3_JSChoice();
            }
        }
        if (SaveData.LastScene.Equals("D4"))
            SceneManager.LoadScene("Day4-3");
        if (SaveData.LastScene.Equals("D5"))
        {
            if (check_D5 == 2)
                SceneManager.LoadScene("Day5-3");
            else
            {
                check_D5++;
                //Debug.Log("check_D5 : " + check_D5);
                D5_JSChoice();
            }
        }
        if (SaveData.LastScene.Equals("D6"))
            SceneManager.LoadScene("Day6-3");
    }

    public void D1_JSChoice()
    {
        SaveData.LastScene = "D1";
        SaveData.Saves();
        random_num = Random.Range(0, 3);
        if (random_num == 0)
            JinSang2_();
        else if (random_num == 1)
            JinSang4_();
        else if (random_num == 2)
            JinSang6_();
    }

    public void D2_JSChoice()
    {
        SaveData.LastScene = "D2";
        SaveData.Saves();

        while(last_num == random_num)
            random_num = Random.Range(0, 4);
        last_num = random_num;
        //Debug.Log("L : " + last_num + "R : " + random_num);

        if (random_num == 0)
            JinSang3_();
        else if (random_num == 1)
            JinSang4_();
        else if (random_num == 2)
            JinSang7_();
        else if (random_num == 3)
            JinSang8_();
    }
    public void D3_JSChoice()
    {
        SaveData.LastScene = "D3";
        SaveData.Saves();

        while (last_num == random_num)
            random_num = Random.Range(0, 4);
        last_num = random_num;

        if (random_num == 0)
            JinSang1_();
        else if (random_num == 1)
            JinSang2_();
        else if (random_num == 2)
            JinSang6_();
        else if (random_num == 3)
            JinSang8_();
    }
    public void D4_JSChoice()
    {
        SaveData.LastScene = "D4";
        SaveData.Saves();
        random_num = Random.Range(0, 2);
        if (random_num == 0)
            JinSang3_();
        else if (random_num == 1)
            JinSang4_();
    }
    public void D5_JSChoice()
    {
        SaveData.LastScene = "D5";
        SaveData.Saves();

        while (last_num == random_num)
            random_num = Random.Range(0, 3);
        last_num = random_num;

        if (random_num == 0)
            JinSang3_();
        else if (random_num == 1)
            JinSang7_();
        else if (random_num == 2)
            JinSang8_();
    }
    public void D6_JSChoice()
    {
        SaveData.LastScene = "D6";
        SaveData.Saves();
        random_num = Random.Range(0, 3);
        if (random_num == 0)
            JinSang2_();
        else if (random_num == 1)
            JinSang4_();
        else if (random_num == 2)
            JinSang5_();
    }
    public void JinSang1_()
    {
        SaveData.JinSangvisit[1]++;
        SaveData.Saves();

        if(SaveData.JinSangvisit[1] == 1)
            SceneManager.LoadScene("JinSang1_1");
    }
    public void JinSang2_()
    {
        SaveData.JinSangvisit[2]++;
        SaveData.Saves();

        if (SaveData.JinSangvisit[2] == 1)
            SceneManager.LoadScene("JinSang2_1");
        else if (SaveData.JinSangvisit[2] == 2)
            SceneManager.LoadScene("JinSang2_2");
        else if (SaveData.JinSangvisit[2] == 3)
            SceneManager.LoadScene("JinSang2_3");
    }
    public void JinSang3_()
    {
        SaveData.JinSangvisit[3]++;
        SaveData.Saves();

        if (SaveData.JinSangvisit[3] == 1)
            SceneManager.LoadScene("JinSang3_1");
        else if (SaveData.JinSangvisit[3] == 2)
            SceneManager.LoadScene("JinSang3_2");
        else if (SaveData.JinSangvisit[3] == 3)
            SceneManager.LoadScene("JinSang3_3");
    }
    public void JinSang4_()
    {
        SaveData.JinSangvisit[4]++;
        SaveData.Saves();

        if (SaveData.JinSangvisit[4] == 1)
            SceneManager.LoadScene("JinSang4_1");
        else if (SaveData.JinSangvisit[4] == 2)
            SceneManager.LoadScene("JinSang4_2");
        else if (SaveData.JinSangvisit[4] == 3)
            SceneManager.LoadScene("JinSang4_3");
        else if (SaveData.JinSangvisit[4] == 4)
            SceneManager.LoadScene("JinSang4_4");
    }
    public void JinSang5_()
    {
        SaveData.JinSangvisit[5]++;
        SaveData.Saves();

        if (SaveData.JinSangvisit[5] == 1)
            SceneManager.LoadScene("JinSang5_1");
    }
    public void JinSang6_()
    {
        SaveData.JinSangvisit[6]++;
        SaveData.Saves();

        if (SaveData.JinSangvisit[6] == 1)
            SceneManager.LoadScene("JinSang6_1");
        else if (SaveData.JinSangvisit[6] == 2)
            SceneManager.LoadScene("JinSang6_2");

    }
    public void JinSang7_()
    {
        SaveData.JinSangvisit[7]++;
        SaveData.Saves();

        if (SaveData.JinSangvisit[7] == 1)
            SceneManager.LoadScene("JinSang7_1");
        else if (SaveData.JinSangvisit[7] == 2)
            SceneManager.LoadScene("JinSang7_2");
    }

    public void JinSang8_()
    {
        SaveData.JinSangvisit[8]++;
        SaveData.Saves();

        if (SaveData.JinSangvisit[8] == 0)
            SceneManager.LoadScene("JinSang8_1");
        else if (SaveData.JinSangvisit[8] == 1)
            SceneManager.LoadScene("JinSang8_2");
        else if (SaveData.JinSangvisit[8] == 2)
            SceneManager.LoadScene("JinSang8_3");
    }

    
}
