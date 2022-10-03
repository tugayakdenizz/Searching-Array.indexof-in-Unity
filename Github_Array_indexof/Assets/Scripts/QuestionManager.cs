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
    public void Answers(string answerInput)
    {
       // answerInput = answerInput.ToLower();
       // answerInput = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(answerInput);
        
        Debug.Log(answerInput);

        int indexNo = Array.IndexOf(questionsArray, answerInput);
        if (indexNo==randomNo)
        {
            Debug.Log("OK" + randomNo + indexNo);

        }
        else
        {
            Debug.Log("Nok" + randomNo + "-" + indexNo);   
        }
    }

}
