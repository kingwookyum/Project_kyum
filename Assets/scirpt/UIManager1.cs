using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager1 : MonoBehaviour
{
    public Image bg;

    public int value_01 = 1;

    bool change;

    Sprite cs; // current sprite 
    public Sprite changesprite;
   

    [SerializeField]
    TextMeshProUGUI text_01;

    private void Start()
    {
        cs = bg.sprite;
    }

    public void ChangeColor()
    {
        bg.color = Color.red;
    }

    public void ChangeText()
    {
        text_01.text = "kkkk?";

        text_01.text = "nidid!";
    }

   public void Changetext()
    {
        if (!change)
        {
            change = true;
            text_01.text = "1 spirte";
            bg.sprite = changesprite;
        }
        else
        {
            change = false;
            text_01.text = "2 spirte";
            bg.sprite = cs;
        }
    }
}

