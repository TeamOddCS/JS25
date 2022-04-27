using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class SaveData : MonoBehaviour
{
    public static string Name = "test";
    public static string checkLevel = "���̵�";
    public static int count; //���� ��ġ ǥ��

    public static string DataPath = "/Userdata.dat";

    public static bool DoChangeData = false;
    public static bool DoLoadData = false;
    public static bool RemakeDataInHub = false;
    public static bool Check_Loads_Files = false;

    public static int[] JinSangvisit = new int[9];
    public static int health = 3;
    public static string JSName = " ";
    public static int reGame;
    public static string reGameStart;
    public static int reGameChoice;

    public static int JinSang6Day1 = 0;

    public static string TempScene = " ";
    public static int TempCount = 0;

    // Start is called before the first frame update

    [Serializable]
    public class Players
    {
        public string name_; //�г���
        public string level_; //���̵�
        public int[] JinSangvisit_; //���� �湮 Ƚ��
        public int JinSang6Day1_; //����6 ù �湮������ ����
        public string TempScene_; //���� ���̾�α� ��ġ
        public int TempCount_;

        public int health_;
        public string JSName_;
        public int reGame_;
        public string reGameStart_;
        public int reGameChoice_;
    }

    public static void Saves()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + DataPath);

        Players data = new Players();

        //A->B
        data.name_ = Name;
        data.level_ = checkLevel;
        data.JinSangvisit_ = JinSangvisit;
        data.health_ = health;
        data.JSName_ = JSName;
        data.reGame_ = reGame;
        data.reGameStart_ = reGameStart;
        data.reGameChoice_ = reGameChoice;
        data.TempScene_ = TempScene;
        data.TempCount_ = TempCount;

        data.JinSang6Day1_ = JinSang6Day1;

        //B����ȭ & ���� ����
        bf.Serialize(file, data);
        file.Close();
    }

    public static void Loads()
    {
        BinaryFormatter bf = new BinaryFormatter();

        try
        {
            FileStream file = File.Open(Application.persistentDataPath + DataPath, FileMode.Open);
            if (file != null && file.Length > 0)
            {
                Players data = (Players)bf.Deserialize(file);

                //B--->A
                Name = data.name_;
                checkLevel = data.level_;
                JinSangvisit = data.JinSangvisit_;
                JinSang6Day1 = data.JinSang6Day1_;
                health = data.health_;
                JSName = data.JSName_;
                reGame = data.reGame_;
                reGameStart = data.reGameStart_;
                reGameChoice = data.reGameChoice_;
                TempScene = data.TempScene_;
                TempCount = data.TempCount_;
            }
            Check_Loads_Files = true;
            file.Close();
        }catch{
            Check_Loads_Files = false;
        }
    }
  


    private void Awake()
    {
        if (DoChangeData == true)
        {
            Saves();

            DoChangeData = false;
        }

        if (DoLoadData == true)
        {
            Loads();

            if (RemakeDataInHub == true)
            {
                //������ remake�ϱ�
                RemakeDataInHub = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (DoChangeData == true)
        {
            Saves();

            DoChangeData = false;
        }

        if (DoLoadData == true)
        {
            Loads();

            if (RemakeDataInHub == true)
            {

                CheckUserData.�̸�Ȯ�ο�.GetComponent<Text>().text = Name;
                CheckUserData.���̵�Ȯ�ο�.GetComponent<Text>().text = checkLevel;

                RemakeDataInHub = false;
            }

            UnityEngine.Debug.Log(Name);
            UnityEngine.Debug.Log(checkLevel);

            DoLoadData = false;
        }
    }
}
