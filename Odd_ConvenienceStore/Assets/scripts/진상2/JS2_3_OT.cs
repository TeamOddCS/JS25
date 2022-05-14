using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS2_3_OT : MonoBehaviour
{
    public GameObject option_page;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        JinSang2_3.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (JS2_3_C.isChoice == true)
        {
            JinSang2_3.isDialogue = false;
        }
        else
        {
            JinSang2_3.isDialogue = true;
        }
    }
}
