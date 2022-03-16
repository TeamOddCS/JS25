using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowExplain : MonoBehaviour
{
    public GameObject explainImg, right, left, finishBtn;
    public Text explainText;
    public int page = 0;
    public bool start = false;
    public string[] content;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void rightBtn()
    {
        if (page == content.Length - 1)
            page += 0;
        else
            page++;

        explainText.text = content[page];
    }

    public void leftBtn()
    {
        if (page == 0)
            page -= 0;
        else
            page--;
        explainText.text = content[page];
    }

    public void startScript()
    {
        explainText.text = content[0];
        explainText.gameObject.SetActive(true);
        explainImg.SetActive(true);
        right.SetActive(true);
        left.SetActive(true);
    }

    public void finish()
    {
        explainText.gameObject.SetActive(false);
        explainImg.SetActive(false);
        right.SetActive(false);
        left.SetActive(false);
        finishBtn.SetActive(false);
        Day4_1.isDialogue = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Day4_1.count == 4 && start == false)
        {
            start = true;
            Day4_1.isDialogue = false;
            startScript();
        }

        if (page == content.Length - 1)
            finishBtn.SetActive(true);
    }
}
