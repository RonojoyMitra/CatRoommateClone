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


    private void Start()
    {
        Question.text = Questions[0];
        Answer1.text = Answer1A[0];
        Answer2.text = Answer2A[0];
    }
    private void Update()
    {
        if (count == 7)
        {
            Question.text = Questions[7];
        }
    }
    public void OnLeftClick()
    {
      count++;
        //for (; count <= 7;)
        if(count < 7)
        {
            Question.text = Questions[count];
            Answer1.text = Answer1A[count];
            Answer2.text = Answer2A[count];
        }
        
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
    }
}