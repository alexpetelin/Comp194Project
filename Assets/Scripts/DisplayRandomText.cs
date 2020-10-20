using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayRandomText : MonoBehaviour
{
    public TextMeshPro _Text;
    private string prompt = "prompt 1";

    void Start()
    {
        _Text = gameObject.AddComponent<TextMeshPro>();
        _Text.text = prompt;
        
        //Text = FindObjectOfType<TextMeshPro>();
    }


    void Update()
    {
        //Text.text = "Prompt 1";
    }
}
