using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day2_3_OT : MonoBehaviour
{
    public GameObject option_page,day2_3;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        Day2_3.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (Day2_3_C.isChoice == true)
        {
            Day2_3.isDialogue = false;
        }
        else
        {
           day2_3.GetComponent<Day2_3>().Showdialogue();
        }
    }
}
