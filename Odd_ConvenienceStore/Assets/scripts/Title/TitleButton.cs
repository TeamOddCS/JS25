using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour
{
    //public GameObject IBM; //-> ó������ �ȴ����� �̾��ϱ� ������ �� ������ ���â

    public void Awake()
    {
        //IBM.SetActive(false);
    }
    public void Goto_GameStart()
    {
        SceneManager.LoadScene("Friend");
    }

    public void Goto_GameContinue()
    {

        SaveData.Loads();

        if (SaveData.Check_Loads_Files == false)
        {
            //IBM.SetActive(true);
        }
        else SceneManager.LoadScene("Convenience Store");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
