using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private GameObject dialogueBox;
    public static bool isInDialogue = false;

    private void Start()
    {
        dialogueBox = GameObject.Find("DialogueBox");
        dialogueBox.SetActive(false);
        isInDialogue = false;
    }

    public void SwitchDialogueBox()
    {
        if (dialogueBox.activeSelf)
        {
            dialogueBox.SetActive(false);
            isInDialogue = false;
            return;
        }
        dialogueBox.SetActive(true);
        isInDialogue = true;
    }
}
