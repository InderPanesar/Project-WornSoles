using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MoodLevel : ScriptableObject, ISerializationCallbackReceiver
{
    public float initialMood;

    [HideInInspector]
    public float runTimeMood;

    public void OnAfterDeserialize() {
        runTimeMood = initialMood;
    }

    public void OnBeforeSerialize() {}
}
