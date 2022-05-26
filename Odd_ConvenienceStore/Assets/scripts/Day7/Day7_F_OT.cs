using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day7_F_OT : MonoBehaviour
{
    public GameObject option_page,day7_f;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        Day7_F.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);
        if (Day7_F_C.isChoice == true)
        {
            Day7_F.isDialogue = false;
        }
        else
        {
            day7_f.GetComponent<Day7_F>().Showdialogue();
        }
    }
}
