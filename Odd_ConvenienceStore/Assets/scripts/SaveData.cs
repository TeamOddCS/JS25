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

    public static int JinSang2visit = 0;
    public static int JinSang4visit = 0;
    public static int JinSang6visit = 0;
    public static int health = 3;
   

    public static int JinSang6Day1 = 0;

    // Start is called before the first frame update

    [Serializable]
    public class Players
    {
        public string name_; //�г���
        public string level_; //���̵�
        public int JinSang2visit_; //���� �湮 Ƚ��
        public int JinSang4visit_;
        public int JinSang6visit_;
        public int JinSang6Day1_; //����6 ù �湮������ ����
      
        public int health_;
    }

    public static void Saves()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + DataPath);

        Players data = new Players();

        //A->B
        data.name_ = Name;
        data.level_ = checkLevel;
        data.JinSang2visit_ = JinSang2visit;
        data.JinSang4visit_ = JinSang4visit;
        data.JinSang6visit_ = JinSang6visit;
        data.health_ = health;

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
                JinSang2visit = data.JinSang2visit_;
                JinSang4visit = data.JinSang4visit_;
                JinSang6visit = data.JinSang6visit_;
                JinSang6Day1 = data.JinSang6Day1_;
                data.health_ = health;

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
