using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS1_1_OT : MonoBehaviour
{
    public GameObject option_page,js1_1;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        JinSang1_1.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (JS1_1_C.isChoice == true)
        {
            JinSang1_1.isDialogue = false;
        }
        else
        {
            js1_1.GetComponent<JinSang1_1>().Showdialogue();
        }
    }
}
