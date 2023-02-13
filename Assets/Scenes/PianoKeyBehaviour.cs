using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class PianoKeyBehaviour : MonoBehaviour
{
    [SerializeField] private Recording recording;
    private string buttonName;

    private void Start()
    {
        buttonName = transform.GetChild(0).GetComponent<TextMeshProUGUI>().text;
    }

    public void updateRecording()
    {
        playKey();
        if (recording.isRecording())
        {
            recording.addToRecording(buttonName);
        }
    }

    public void playKey()
    {
        recording.playKey(buttonName);
    }
}
