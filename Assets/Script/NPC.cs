using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
public class NPC : MonoBehaviour
{
    //public YarnProgram currentDialogueYarnProgarm;
    public string CurrentStartNode = "Start";
    public DialogueRunner dialogueRunner;

    public bool talkable;
    public GameObject TalkUI;


    public void SetDialogue()
    {
        if (dialogueRunner != null && talkable)
        {
            dialogueRunner.StartDialogue("Start");
            
        }

    }

    public void ShowTalkUI(bool show)
    {
        if (show)
        {
            TalkUI.SetActive(true);
        }
        else
        {
            TalkUI.SetActive(false);

        }
       

    }




}
