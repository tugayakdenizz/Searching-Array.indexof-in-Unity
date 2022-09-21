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
    public string[] questionsArray;
    public string[] answerArray;
    int randomNo;

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
        randomNo = UnityEngine.Random.Range(0, questionsArray.Length);
        questionText.text = questionsArray[randomNo].ToString();
        

    }
    public void Answers(string Input)
    {
        Input = Input.ToLower();
        Input = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Input);
        int indexNo = Array.IndexOf(questionsArray, Input);
        if (indexNo==randomNo)
        {
            Debug.Log("OK");
        }
        else
        {
            Debug.Log("Nok");   
        }
    }

}
