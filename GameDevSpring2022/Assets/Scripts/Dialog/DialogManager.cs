using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    private Queue<string> Sentences;
    void Start()
    {
        Sentences = new Queue<string>();

    }

    public void StartDialogue(Dialogue dialogue) 
    {

        Debug.Log("Starting Conversation with" + dialogue.name);

    }
}

