using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day5_3_OT : MonoBehaviour
{
    public GameObject option_page,day5_3;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        Day5_3.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (Day5_3_C.isChoice == true)
        {
            Day5_3.isDialogue = false;
        }
        else
        {
            day5_3.GetComponent<Day5_3>().Showdialogue();
        }
    }
}
