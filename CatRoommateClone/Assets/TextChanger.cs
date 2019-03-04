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

    private void Start()
    {
        Question.text = Questions[0];
        Answer1.text = Answer1A[0];
        Answer2.text = Answer2A[0];
    }
}