using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnoDialogue : MonoBehaviour
{
    void Reset()
    {
        txt_dialogue = null;
        txt_name = null;

    }
    [SerializeField] private Text txt_dialogue; 
    [SerializeField] private Text txt_name;
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;

    public void Showdialogue()
    {
        txt_dialogue.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        count = 0;
        isDialogue = true;

    }
    public void Nextdialogue()
    {
        count++;
        Debug.Log(count);
        txt_dialogue.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        txt_name.text = data[count]["Name"].ToString();
        data[count]["Script"] = data[count]["Script"].ToString().Replace("#", ",");
        data[count]["Script"] = data[count]["Script"].ToString().Replace("  ", "\n");
        txt_dialogue.text = data[count]["Script"].ToString();


    }


    private void Hidedialogue()
    {
        txt_name.gameObject.SetActive(false);
        txt_dialogue.gameObject.SetActive(false);
        isDialogue = false;
    }

    private void Start()
    {

        data = CSVReader.Read("Day1-1");
        Showdialogue();
    }
    // Update is called once per frame
    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetMouseButtonUp(0))
            {
                if (count < data.Count)
                {
                    Nextdialogue();

                    if (count == 27)
                    {
                        count += 1;
                    }
                    if (count == 30)
                    {
                        count += 11;
                    }
                    if (count == 32)
                    {
                        count += 2;
                    }
                    if (count == 38)
                    {
                        count += 3;
                    }

                    if (count == 40)
                    {
                        count += 1;
                    }
                    //if(count == 50) GameObject.Find("Canvas").transform.FindChild(" 1").gameObject.SetActive(true);
                    //if(count == 50) GameObject.Find("Canvas").transform.FindChild("2").gameObject.SetActive(true);
                    //if(count == 50) GameObject.Find("Canvas").transform.FindChild(" 3").gameObject.SetActive(true);
                    if (count == 73)
                    {
                        count += 1;
                    }
                    if (count == 76)
                    {
                        count += 3;
                    }
                    if (count == 81)
                    {
                        count += 3;
                    }
                }
                else
                {
                    fade.Fade();
                    Hidedialogue();
                }

            }
        }
        else
            Hidedialogue();
    }
}
