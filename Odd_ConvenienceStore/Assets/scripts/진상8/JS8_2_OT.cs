using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS8_2_OT : MonoBehaviour
{
    public GameObject option_page;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        JinSang8_2.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (JS8_2_C.isChoice == true)
        {
            JinSang8_2.isDialogue = false;
        }
        else
        {
            JinSang8_2.isDialogue = true;
        }
    }
}
