using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextChanger : MonoBehaviour
{
    public TextMeshProUGUI Question;
    public string[] Questions;
    public TextMeshProUGUI Answer1;
    public string[] Answer1A;
    public TextMeshProUGUI Answer2;
    public string[] Answer2A;
    int count = 0;
    int correctCount = 0;


    private void Start()
    {
        Question.text = Questions[0];
        Answer1.text = Answer1A[0];
        Answer2.text = Answer2A[0];
    }
    private void Update()
    {
        //if (count == 0 && OnLeftClick() == true || count == 1 && OnLeftClick() == true ||
        //    count == 2 && OnRightClick() == true || count == 3 && OnRightClick() == true ||
        //    count == 4 && OnLeftClick() == true || count == 5 && OnLeftClick() == true ||
        //    count == 6 && OnLeftClick() == true)
        //{
        //    Debug.Log("CorrectCount increment");
        //    correctCount++;
        //}
        //if (count == 1 && OnLeftClick() == true)
        //{
        //    correctCount++;
        //}
        //if (count == 2 && OnRightClick() == true)
        //{
            
        //}
        if (count == 7 && correctCount > 3)
        {
            Question.text = Questions[7];
        }
        if (count == 7 && correctCount <= 3)
        {
            Question.text = Questions[8];
        }
    }
    public void OnLeftClick()
    {
      count++;
        //for (; count <= 7;)
        if (count < 7)
        {
            Question.text = Questions[count];
            Answer1.text = Answer1A[count];
            Answer2.text = Answer2A[count];
        }
        if (count == 0 || count == 1 ||
            count == 4 || count == 5 ||
            count == 6)
        {
            Debug.Log("Left answer increment");
            correctCount++;
        }
        //return true;
    }
    public void OnRightClick()
    {
        count++;
        if (count < 7)
        {
            Question.text = Questions[count];
            Answer1.text = Answer1A[count];
            Answer2.text = Answer2A[count];
        }
        if (count == 2 || count == 3)
        {
            Debug.Log("Right answer increment");
            correctCount++;
        }
        //return true;
    }
}