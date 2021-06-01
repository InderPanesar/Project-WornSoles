using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoodSignalListener : MonoBehaviour
{

    public MoodSignal moodSignal;
    public UnityEvent moodSignalEvent;
    public void OnSignalRaised()
    {
        moodSignalEvent.Invoke();
    }

    private void OnEnable()
    {
        moodSignal.RegisterListener(this);
    }

    private void OnDisable()
    {
        moodSignal.DeRegisterListener(this);
    }
}
