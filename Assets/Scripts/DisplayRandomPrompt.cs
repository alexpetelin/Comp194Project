using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayRandomPrompt : MonoBehaviour
{

    public TMP_Text randomPrompt;

    public string [ ] promptList = new string [ ]{"horse", "house", "tree", "robot"};
  
    // public string promptOne = "horse";
    // public string promptTwo = "house";
    // public string promptThree = "camera";
    // public string promptFour = "robot";
    // public string promptFive = "tree";
    
    // public List promptsList;
    // List<string> promptsList = new List<string>();
    // public static int Random.Range();
    // public TextMeshPro _Text;
    // private string prompt = "prompt 1";

    void Start()
    {   
        int a = Random.Range(0, promptList.Length - 1);
        string prompt = promptList[a];
        Debug.Log(prompt);
        randomPrompt.text = prompt;




        // if(a = 1)
        // {
        //     Debug.Log(promptOne);
        //     randomPrompt.text = promptOne;
        // }

        // else if(a = 2)
        // {
        //     Debug.Log(promptTwo);
        //     randomPrompt.text = promptTwo;
        // }
        // else if(a = 3)
        // {
        //     Debug.Log(promptThree);
        //     randomPrompt.text = promptThree;
        // }
        // else if(a = 4)
        // {
        //     Debug.Log(promptFour);
        //     randomPrompt.text = promptFour;
        // }
        // else if(a = 5)
        // {
        //     Debug.Log(promptFive);
        //     randomPrompt.text = promptFive;
        // }



/////////////////////

        // promptsList.Add("horse");
        // promptsList.Add("house");        
        // promptsList.Add("camera");
        // promptsList.Add("robot");
        // promptsList.Add("tree");

        // randomPrompt.text = prompsList [Random.Range(0, prompsList.Count)];

/////////////////////

        // if(Random.Range(, 5.0f) = 1.0f)
        // {
        //     Debug.Log(promptOne);
        //     randomPrompt.text = promptOne;
        // }
        // else if(Random.Range(1.0f, 5.0f) = 2.0f)
        // {
        //     Debug.Log(promptTwo);
        //     randomPrompt.text = promptTwo;
        // }
        // else if(Random.Range(1.0f, 5.0f) = 3.0f)
        // {
        //     Debug.Log(promptThree);
        //     randomPrompt.text = promptThree;
        // }
        // else if(Random.Range(1.0f, 5.0f) = 4.0f)
        // {
        //     Debug.Log(promptFour);
        //     randomPrompt.text = promptFour;
        // }
        // else if(Random.Range(1.0f, 5.0f) = 5.0f)
        // {
        //     Debug.Log(promptFive);
        //     randomPrompt.text = promptFive;
        // }
        // _Text = gameObject.AddComponent<TextMeshPro>();
        // _Text.text = prompt;
        //Text = FindObjectOfType<TextMeshPro>();
    }


    void Update()
    {
        // randomPrompt.text = "horse";
        //Text.text = "Prompt 1";
    }
}
