using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS3_1_OT : MonoBehaviour
{
    public GameObject option_page;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        JinSang3_1.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (JS3_C.isChoice == true)
        {
            JinSang3_1.isDialogue = false;
        }
        else
        {
            JinSang3_1.isDialogue = true;
        }
    }
}
