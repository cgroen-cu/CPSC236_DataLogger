using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Globalization;

public class GameManagerScript : MonoBehaviour
{
    public string filepath = "log.txt";
    public string forWrite = "";
    // Start is called before the first frame update
    void Start()
    {
        CreateFile();
        //ReadFile();
        //WriteFile();
        //ReadFile();
        WriteStart();
    }

    // Update is called once per frame
    void Update()
    {
        WriteSpacebarInput();
    }

    private void CreateFile()
    {
        File.Create(filepath).Close();
    }

    private void ReadFile()
    {
        using (StreamReader reader = new StreamReader(filepath))
        {
            while (!reader.EndOfStream) // while not at the end
            {
                //keep reading
                Debug.Log(reader.ReadLine());
            }
        }
    }

    private void WriteFile()
    {
        using (StreamWriter writer = File.AppendText(filepath))
        {
            writer.WriteLine(forWrite);
        }
    }

    private string getDate()
    {
        DateTime localDate = DateTime.Now;
        //Debug.Log(localDate.ToString);
        return localDate.ToString();
    }

    private void WriteStart()
    {
        String s1 = "Startup: ";
        s1 += getDate();
        Debug.Log(s1);
        forWrite = s1;
        WriteFile();
    }
    void OnApplcationQuit()
    {
        String s1 = "Shutdown: ";
        s1 += getDate();
        Debug.Log("Application shutdown");
        Debug.Log(s1);
        forWrite = s1;
        WriteFile();
    }
    
    private void WriteSpacebarInput()
    {
        if (Input.GetKeyDown("space"))
        {
            String s1 = "Spacebar: ";
            s1 += getDate();
            Debug.Log(s1);
            forWrite = s1;
            WriteFile();
        }
    }
    public void WriteButtonInput()
    {
        String s1 = "Button clicked: ";
        s1 += getDate();
        Debug.Log(s1);
        forWrite = s1;
        WriteFile();
    }
}
