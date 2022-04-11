using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JSChoice : MonoBehaviour
{
    private int random_num = 0;

    // Start is called before the first frame update
    void Start()
    {
        SaveData.DoChangeData = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void D1_JSChoice()
    {
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
        random_num = Random.Range(0, 4);
        if (random_num == 0)
            JinSang3_();
        else if (random_num == 1)
            JinSang4_();
        else if (random_num == 2)
            JinSang7_();
        //else if (random_num == 3)
        //  JinSang8_();
    }
    public void D3_JSChoice()
    {
        random_num = Random.Range(0, 4);
        if (random_num == 0)
            JinSang1_();
        else if (random_num == 1)
            JinSang2_();
        else if (random_num == 2)
            JinSang6_();
        //else if (random_num == 3)
        //  JinSang8_();
    }
    public void D4_JSChoice()
    {
        random_num = Random.Range(0, 2);
        if (random_num == 0)
            JinSang3_();
        else if (random_num == 1)
            JinSang4_();
    }
    public void D5_JSChoice()
    {
        random_num = Random.Range(0, 3);
        if (random_num == 0)
            JinSang3_();
        else if (random_num == 1)
            JinSang7_();
        //else if (random_num == 2)
            //JinSang8_();
    }
    public void D6_JSChoice()
    {
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

        if(SaveData.JinSangvisit[1] == 0)
            SceneManager.LoadScene("JinSang1_1");
    }
    public void JinSang2_()
    {
        SaveData.JinSangvisit[2]++;
        SaveData.Saves();

        if (SaveData.JinSangvisit[2] == 0)
            SceneManager.LoadScene("JinSang2_1");
        else if (SaveData.JinSangvisit[2] == 1)
            SceneManager.LoadScene("JinSang2_2");
        else if (SaveData.JinSangvisit[2] == 2)
            SceneManager.LoadScene("JinSang2_3");
    }
    public void JinSang3_()
    {
        SaveData.JinSangvisit[3]++;
        SaveData.Saves();

        if (SaveData.JinSangvisit[3] == 0)
            SceneManager.LoadScene("JinSang3_1");
        else if (SaveData.JinSangvisit[3] == 1)
            SceneManager.LoadScene("JinSang3_2");
        else if (SaveData.JinSangvisit[3] == 2)
            SceneManager.LoadScene("JinSang32_3");
    }
    public void JinSang4_()
    {
        SaveData.JinSangvisit[4]++;
        SaveData.Saves();

        if (SaveData.JinSangvisit[4] == 0)
            SceneManager.LoadScene("JinSang4_1");
        else if (SaveData.JinSangvisit[4] == 1)
            SceneManager.LoadScene("JinSang4_2");
        else if (SaveData.JinSangvisit[4] == 2)
            SceneManager.LoadScene("JinSang4_3");
        else if (SaveData.JinSangvisit[4] == 3)
            SceneManager.LoadScene("JinSang4_4");
    }
    public void JinSang5_()
    {
        SaveData.JinSangvisit[5]++;
        SaveData.Saves();

        if (SaveData.JinSangvisit[5] == 0)
            SceneManager.LoadScene("JinSang5_1");
    }
    public void JinSang6_()
    {
        SaveData.JinSangvisit[6]++;
        SaveData.Saves();

        if (SaveData.JinSangvisit[6] == 0)
            SceneManager.LoadScene("JinSang6_1");
        else if (SaveData.JinSangvisit[6] == 1)
            SceneManager.LoadScene("JinSang6_2");

    }
    public void JinSang7_()
    {
        SaveData.JinSangvisit[7]++;
        SaveData.Saves();

        if (SaveData.JinSangvisit[7] == 0)
            SceneManager.LoadScene("JinSang7_1");
        else if (SaveData.JinSangvisit[7] == 1)
            SceneManager.LoadScene("JinSang7_2");
    }

    //기획나오면 추가
    /*public void JinSang8_()
    {
        SaveData.JinSangvisit[8]++;
        SaveData.Saves();

        if (SaveData.JinSangvisit[8] == 0)
            SceneManager.LoadScene("JinSang8_1");
        else if (SaveData.JinSangvisit[8] == 1)
            SceneManager.LoadScene("JinSang8_2");
        else if (SaveData.JinSangvisit[8] == 2)
            SceneManager.LoadScene("JinSang8_3");
    }*/
}
