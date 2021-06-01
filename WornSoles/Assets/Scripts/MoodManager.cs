using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoodManager : MonoBehaviour
{
    public MoodLevel moodLevel;
    public Text moodLabel;
    
    // Start is called before the first frame update
    void Start() {
    }

    public void MoodLevelString()
    {
       String s = "Mood Level = " + moodLevel.runTimeMood;
       moodLabel.text = s;
    }
    
}
