using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MoodSignal : ScriptableObject
{
    public List<MoodSignalListener> listeners = new List<MoodSignalListener>();

    public void Raise()
    {
        for(int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnSignalRaised();
        }
    }

    public void RegisterListener(MoodSignalListener listener)
    {
        listeners.Add(listener);
    }

    public void DeRegisterListener(MoodSignalListener listener)
    {
        listeners.Remove(listener);
    }
}
