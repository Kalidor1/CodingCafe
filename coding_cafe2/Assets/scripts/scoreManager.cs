using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManager : MonoBehaviour

{
    public TextMeshProUGUI text;
    public static scoreManager instance;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ScoreFunction(int value)
    {
        score += value;
        text.text = "Score: " + score.ToString();
    }
}
