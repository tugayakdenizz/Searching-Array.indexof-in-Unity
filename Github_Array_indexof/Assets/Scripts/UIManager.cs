using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_InputField answerInput;
    

    public void AnswerControlButon()
    {
       QuestionManager.Instance.Answers(answerInput.text);
    }
    public void QuestionNextButon()
    {
        QuestionManager.Instance.Questions();
    }
}
