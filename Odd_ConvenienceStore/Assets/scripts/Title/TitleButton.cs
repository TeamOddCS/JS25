using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour
{   
    public GameObject IBM; //-> 처음부터 안누르고 이어하기 눌렀을 때 나오는 경고창
    public AudioClip titleclip;
    public void Awake()
    {
        IBM.SetActive(false);
    }
    public void Goto_GameStart()
    {
        SaveData.DoChangeData = true;
        SceneManager.LoadScene("Day0");
    }

    public void Goto_GameContinue()
    {

        SaveData.Loads();

        if (SaveData.Check_Loads_Files == false)
        {
           IBM.SetActive(true);
        }
        else SceneManager.LoadScene(SaveData.TempScene);
        Debug.Log(SaveData.TempScene);
    }

    public void OK_Button()
    {
        IBM.SetActive(false);
    }

    public void Quit_Button()
    {
        Application.Quit();
    }

    //public void BtnSound()
    //{
    //    SoundManager.instance.SFXPlay("title", titleclip);
    //}


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
