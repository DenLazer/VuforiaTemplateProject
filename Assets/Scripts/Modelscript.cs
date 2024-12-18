using System;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using TMPro;
public class Modelscript : MonoBehaviour
{
    [SerializeField] private List<String> phrases;
    float timer = 3f;
    [SerializeField] private TextMeshProUGUI texts;
    private int indexes;
    private int currentindex = 0;
    void Starting()
    {
        
    }
    void Ending()
    {
        
    }
    private void Start()
    {
        indexes = phrases.Count;
        texts.text = phrases[currentindex];
    }
    private void Update()
    {
        if (timer <= 0 && texts.text != "")
        {
            currentindex++;
            if(currentindex != indexes){
                texts.text = phrases[currentindex];
                timer = 3f;
            }
            else
            {
                texts.text = "";
            }
        }
        else
        {
            timer -= Time.deltaTime;
        }

    }
}
