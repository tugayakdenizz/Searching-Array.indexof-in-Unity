using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using System.Globalization;

public class QuestionManager : MonoBehaviour
{
    public static QuestionManager Instance = null;

    public TextMeshProUGUI questionText;
    public string[] QuestionsArray;
    public string[] AnswerArray;
    int RandomNo;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        Questions();
    }

    public void Questions()
    {
        RandomNo = UnityEngine.Random.Range(0, QuestionsArray.Length);
        questionText.text = QuestionsArray[RandomNo].ToString();
        

    }
    public void Answers(string Input)
    {
        Input = Input.ToLower();
        Input = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Input);
        int indexNo = Array.IndexOf(QuestionsArray, Input);
        if (indexNo==RandomNo)
        {
            Debug.Log("OK");
        }
        else
        {
            Debug.Log("Nok");   
        }
    }

}
