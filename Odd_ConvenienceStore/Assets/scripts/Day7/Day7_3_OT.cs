using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day7_3_OT : MonoBehaviour
{
    public GameObject option_page, day7_3;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        Day7_3.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (Day7_3_C.isChoice == true)
        {
            Day7_3.isDialogue = false;
        }
        else
        {
            day7_3.GetComponent<Day7_3>().Showdialogue();
        }
    }
}
