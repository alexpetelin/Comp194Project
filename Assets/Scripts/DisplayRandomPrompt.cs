using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DisplayRandomText : MonoBehaviour
{

    public TMP_Text randomPrompt;
    public string [ ] promptList = new string [ ]{"horse", "house", "tree", "robot"};
    
    
    // public TextMeshPro _Text;
    // private string prompt = "prompt 1";

    void Start()
    {
        // _Text = gameObject.AddComponent<TextMeshPro>();
        // _Text.text = prompt;
        //Text = FindObjectOfType<TextMeshPro>();
    }


    void Update()
    {
        randomPrompt.text = "horse";
        //Text.text = "Prompt 1";
    }
}
