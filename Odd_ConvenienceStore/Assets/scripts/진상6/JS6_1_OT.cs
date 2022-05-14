using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS6_1_OT : MonoBehaviour
{

    public GameObject option_page;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        JinSang6_1.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (JS6_1_C.isChoice == true)
        {
            JinSang6_1.isDialogue = false;
        }
        else
        {
            JinSang6_1.isDialogue = true;
        }
    }
}
