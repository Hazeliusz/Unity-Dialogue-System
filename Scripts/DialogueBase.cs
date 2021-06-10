using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class DialogueBase : MonoBehaviour
{
    public string[] speakersNames = {"self", "monologist"};
    public Sprite[] speakersSprites;
    [TextArea(3, 10)]
    public string[] lines;
    public Queue<string> dialogues = new Queue<string>();
    public Text textField;
    public Text nameField;
    public Image spriteField;
    int currentSpeaker;
    GameController gameController;

    public void StartDialogue(bool monologue)
    {
        gameController.SwitchDialogueBox();
        dialogues.Clear();
        StopAllCoroutines();
        foreach (string line in lines)
            dialogues.Enqueue(line);
        if (monologue) {
            nameField.text = speakersNames[1];
            spriteField.sprite = speakersSprites[1];
            StartCoroutine(DialogueLoop());
            return;
        }
        StartCoroutine(Interact());
    }

    IEnumerator DialogueLoop()
    {
        while (true)
        {
            NextLine();
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
            yield return new WaitForFixedUpdate();
        }
    }
    protected void NextLine()
    {
        if (dialogues.Count == 0)
        {
            EndDialogue();
            return;
        }
        textField.text = dialogues.Dequeue();
    }

    protected IEnumerator NextLineAndWait()
    {
        NextLine();
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return new WaitForFixedUpdate();
    }

    protected IEnumerator WaitForDialogues(int amount)
    {
        for(int i = 0; i < amount; i++)
        {
            yield return NextLineAndWait();
        }
    }

    protected void EndDialogue()
    {
        gameController.SwitchDialogueBox();
        StopAllCoroutines();
    }
    public virtual IEnumerator Interact()
    {
        return null;
    }

    protected void ChangeSpeaker(int speaker)
    {
        nameField.text = speakersNames[speaker];
        spriteField.sprite = speakersSprites[speaker];
    }

    private void Awake()
    {
        gameController = FindObjectOfType<GameController>();
    }

    protected int Choice()
    {

    }
}
