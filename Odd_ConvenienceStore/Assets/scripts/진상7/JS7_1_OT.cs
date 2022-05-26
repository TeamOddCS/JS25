using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS7_1_OT : MonoBehaviour
{
    public GameObject option_page,js7_1;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        JinSang7_1.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (JS7_1_C.isChoice == true)
        {
            JinSang7_1.isDialogue = false;
        }
        else
        {
            js7_1.GetComponent<JinSang7_1>().Showdialogue();
        }
    }
}
