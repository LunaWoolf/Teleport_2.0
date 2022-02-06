using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.InputSystem;

public class PossessNPC : MonoBehaviour
{
    SkinnedMeshRenderer meshRenderer;
    public Material normalMaterial;
    public Material possessMaterial;

    private PlayerControls PlayerControls;
    private InputAction StartConversation;

    //public YarnProgram currentDialogueYarnProgarm;

    public string CurrentStartNode = "Start";

    public DialogueRunner dialogueRunner;

    public bool talkable;
    public bool Possessable;
    public bool startDialogue;
    public GameObject TalkUI;

    private void Awake()
    {
        PlayerControls = new PlayerControls();

    }


    private void OnEnable()
    {
        
        StartConversation = PlayerControls.PlayerAction.StartConversation;
        StartConversation.Enable();

        PlayerControls.PlayerAction.StartConversation.performed += ctx => NextDialogue();

    }

    void Start()
    {
        meshRenderer = this.gameObject.GetComponentInChildren<SkinnedMeshRenderer>();
       
    }


    public void ChangeMaterial(bool possess)
    {
        if (possess)
        {
            meshRenderer.material = possessMaterial;

        }
        else
        {
            meshRenderer.material = normalMaterial;
        }

    }

    public void SetDialogue()
    {


        if (dialogueRunner != null && talkable)
        {
            dialogueRunner.StartDialogue("Start");
            startDialogue = true;
        }
        

        /*
        if (currentDialogueYarnProgarm != null && dialogueRunner != null && talkable)
        {
            dialogueRunner.yarnScripts[0] = currentDialogueYarnProgarm;
            dialogueRunner.StartDialogue();
            startDialogue = true;
        }
        */
    }

    private void NextDialogue()
    {
        /*if (startDialogue && dialogueManager != null)
        {
            Debug.Log("nextline");
            //dialogueManager.GetComponent<DialogueUI>().MarkLineComplete();
        }*/

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

    public void DisableTalkable()
    {
        talkable = false;
     
    }

}
