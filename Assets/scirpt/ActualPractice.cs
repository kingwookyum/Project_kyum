using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
public class ActualPractice : MonoBehaviour
{
    public Image bg;

    public int change;

    public Image Cha1;

    public Image Cha2;


    Sprite cs; // current sprite 
    public Sprite changesprite;

    public Sprite changesprite2;

    [SerializeField]
    TextMeshProUGUI Name;

    [SerializeField]
    TextMeshProUGUI Dialog;



    public void Conversation()
    {
        if (change == 0)
        {

            Name.text = "Stewat";
            Dialog.text = "hi";
        }
        else if (change == 1)
        {
            Name.text = "Bob";
            Dialog.text = "Yo!";
        }
        else if (change == 2)
        {
            Name.text = "Bob";
            Dialog.text = "how about watching movie?";
        }
        change += 1;
    }
}