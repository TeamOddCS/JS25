using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day7_1_OT : MonoBehaviour
{
    public GameObject option_page,day7_1;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        Day7_1.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (Day7_1_C.isChoice == true)
        {
            Day7_1.isDialogue = false;
        }
        else
        {
            day7_1.GetComponent<Day7_1>().Showdialogue();
        }
    }
}
