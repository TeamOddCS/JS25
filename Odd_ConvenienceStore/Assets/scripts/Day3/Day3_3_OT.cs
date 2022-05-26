using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day3_3_OT : MonoBehaviour
{
    public GameObject option_page,day3_3;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        Day3_3.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (Day3_3_C.isChoice == true)
        {
            Day3_3.isDialogue = false;
        }
        else
        {
            day3_3.GetComponent<Day3_3>().Showdialogue();
        }
    }
}
