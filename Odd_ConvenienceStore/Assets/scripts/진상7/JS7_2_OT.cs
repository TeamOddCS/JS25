using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS7_2_OT : MonoBehaviour
{
    public GameObject option_page,js7_2;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        JinSang7_2.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (JS7_2_C.isChoice == true)
        {
            JinSang7_2.isDialogue = false;
        }
        else
        {
            js7_2.GetComponent<JinSang7_2>().Showdialogue();
        }
    }
}
