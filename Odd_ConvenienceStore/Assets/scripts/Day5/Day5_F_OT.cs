using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day5_F_OT : MonoBehaviour
{
    public GameObject option_page;

    public void OptionOn()
    {
        Time.timeScale = 0;
        option_page.SetActive(true);
        Day5_F.isDialogue = false;
    }
    public void OptionOff()
    {
        Time.timeScale = 1;
        option_page.SetActive(false);     
        Day5_F.isDialogue = true;
        
    }
}
