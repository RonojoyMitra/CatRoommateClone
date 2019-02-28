using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextChanger : MonoBehaviour
{
    public TextMeshProUGUI Question;
    public string[] Questions;

    private void Start()
    {
        Question.text = Questions[0];
    }
    
    
}