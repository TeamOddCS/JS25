using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test_JinSang : MonoBehaviour
{
    int Random_Customer;
    // Start is called before the first frame update
    void Start()
    {
        Random_Customer = 0 ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void JinSangTest()
    {
        SaveData.Loads();
        Random_Customer = Random.Range(0, 3);
        if (Random_Customer == 0)
        {
            if (SaveData.JinSang2visit == 0)
            {
                SceneManager.LoadScene("JinSang2_0");
                SaveData.JinSang2visit++;
                SaveData.Saves();
            }

            else if (SaveData.JinSang2visit == 1)
            {
                SceneManager.LoadScene("JinSang2_1");
                SaveData.JinSang2visit++;
                SaveData.Saves();
            }
            else Debug.Log("2¿ÃªÛµ ");
        }
        else if (Random_Customer == 1)
        {
            if (SaveData.JinSang4visit == 0)
            {
                SceneManager.LoadScene("JinSang4_0");
                SaveData.JinSang4visit++;
                SaveData.Saves();
            }
                
            else if (SaveData.JinSang4visit == 1)
            {
                SceneManager.LoadScene("JinSang4_1");
                SaveData.JinSang4visit++;
                SaveData.Saves();
            }
            else Debug.Log("2¿ÃªÛµ ");
        }
        else if (Random_Customer == 2)
        {
            if (SaveData.JinSang6visit == 0)
            {
                SceneManager.LoadScene("JinSang6_0");
                SaveData.JinSang6visit++;
                SaveData.Saves();
            }
            else if (SaveData.JinSang6visit == 1)
            {
                SceneManager.LoadScene("JinSang6_1");
                SaveData.JinSang6visit++;
                SaveData.Saves();
            }
            else Debug.Log("2¿ÃªÛµ ");
        }
    }

    public void JinSangReset()
    {
        SaveData.Loads();
        SaveData.JinSang2visit = 0;
        SaveData.JinSang4visit = 0;
        SaveData.JinSang6visit = 0;
        SaveData.Saves();
    }

    public void GotoTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
