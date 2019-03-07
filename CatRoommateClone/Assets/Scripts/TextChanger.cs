using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    public TextMeshProUGUI _Question;
    public string[] _Questions;
    public TextMeshProUGUI _Answer1;
    public string[] _Answer1A;
    public TextMeshProUGUI _Answer2;
    public string[] _Answer2A;
    public Image _CatSprite;
    //public Image[] _CatSpritess;
    public Sprite[] _CatSprites;
    int _count = 0;
    int _correctCount = 0;


    private void Start()
    {
        _Question.text = _Questions[0];
        _Answer1.text = _Answer1A[0];
        _Answer2.text = _Answer2A[0];
        _CatSprite.sprite = _CatSprites[0];
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
        if (_count == 7 && _correctCount > 3)
        {
            _Question.text = _Questions[7];
            _CatSprite.sprite = _CatSprites[1];
        }
        if (_count == 7 && _correctCount <= 3)
        {
            _Question.text = _Questions[8];
            _CatSprite.sprite = _CatSprites[7];
        }
    }
    public void OnLeftClick()
    {
      _count++;
        //for (; count <= 7;)
        if (_count < 7)
        {
            _Question.text = _Questions[_count];
            _Answer1.text = _Answer1A[_count];
            _Answer2.text = _Answer2A[_count];
        }
        if (_count == 0 || _count == 1 ||
            _count == 4 || _count == 5 ||
            _count == 6)
        {
            Debug.Log("Left answer increment");
            _correctCount++;
        }
        //return true;
    }
    public void OnRightClick()
    {
        _count++;
        if (_count < 7)
        {
            _Question.text = _Questions[_count];
            _Answer1.text = _Answer1A[_count];
            _Answer2.text = _Answer2A[_count];
        }
        if (_count == 2 || _count == 3)
        {
            Debug.Log("Right answer increment");
            _correctCount++;
        }
        //return true;
    }
}