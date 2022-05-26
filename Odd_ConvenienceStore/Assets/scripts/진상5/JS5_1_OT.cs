using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS5_1_OT : MonoBehaviour
{
    public GameObject option_page,js5_1;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        JinSang5_1.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (JS5_1_C.isChoice == true)
        {
            JinSang5_1.isDialogue = false;
        }
        else
        {
            js5_1.GetComponent<JinSang5_1>().Showdialogue();
        }
    }
}
