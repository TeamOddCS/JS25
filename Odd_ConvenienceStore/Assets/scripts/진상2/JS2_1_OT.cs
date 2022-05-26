using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS2_1_OT : MonoBehaviour
{
    public GameObject option_page,js2_1;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        JinSang2_1.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (JS2_1_C.isChoice == true)
        {
            JinSang2_1.isDialogue = false;
        }
        else
        {
            js2_1.GetComponent<JinSang2_1>().Showdialogue();
        }
    }
}
