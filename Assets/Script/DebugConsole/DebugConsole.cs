using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DebugConsole : MonoBehaviour
{
    bool showConsole;

    string input;

    private PlayerControls PlayerControls;
    private InputAction toggleDebug;
    private InputAction returnDebug;

    public PlayerMovement playerMovement;
    public PlayerInteraction playerInteraction;

    public List<object> commandList;

    public static DebugCommand Help;
    public static DebugCommand<int> Health_set;
    public static DebugCommand Health_max;
    public static DebugCommand<string> Create_quest;

    public GameManager gm;
    public bool showHelp;
    private Vector2 scroll;

    private void Awake()
    {
        PlayerControls = new PlayerControls();

        Help = new DebugCommand("help", "help", "help", () =>
        {
            showHelp = !showHelp;

        });

        Health_set = new DebugCommand<int>("health_set", "Health_set", "Health_set", (x) =>
        {
            gm.UpdateHealth(x);

        });

        Health_max = new DebugCommand("health_max", "health_max", "debug", () =>
        {
            gm.UpdateHealth(100);

        });

        Create_quest = new DebugCommand<string>("create_quest", "create_quest", "create_quest", (x) =>
        {
            string[] p = input.Split(' ');
            gm.CreateQuest(p[1], p[2], p[3]);

        });


        commandList = new List<object>
        {
            Health_set,
            Health_max,
            Help,
            Create_quest
        };
    }

    private void OnEnable()
    {
        toggleDebug = PlayerControls.Debug.ToggleDebug;
        toggleDebug.Enable();

        returnDebug = PlayerControls.Debug.ReturnDebug;
        returnDebug.Enable();


        PlayerControls.Debug.ToggleDebug.performed += ctx => OnToggleDebug();
        PlayerControls.Debug.ReturnDebug.performed += ctx => OnReturn();
    }

    public void OnToggleDebug()
    {

        showConsole = !showConsole;
        if (showConsole)
        {
            Cursor.lockState = CursorLockMode.None;
            playerMovement.DisableAllInput();
            playerInteraction.DisableAllInput();
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            playerMovement.EnableAllInput();
            playerInteraction.EnableAllInput();
        }
    }

    private void OnGUI()
    {
        if (!showConsole) { return; }

        float y = 0f;

        if (showHelp)
        {
            GUI.Box(new Rect(0, y, Screen.width, 100), "");

            Rect viewport = new Rect(0, 0, Screen.width - 30, 20 * commandList.Count);

            scroll = GUI.BeginScrollView(new Rect(0, y + 5f, Screen.width, 90), scroll, viewport);

            for (int i = 0; i < commandList.Count; i++)
            {
                DebugCommandBase command = commandList[i] as DebugCommandBase;

                string label = $"{command.commandId} - {command.commandDescription}";

                Rect labelRect = new Rect(5, 20 * i, viewport.width - 100, 20);

                GUI.Label(labelRect, label);
            }


            GUI.EndScrollView();

            y += 100;


        }

        GUI.Box(new Rect(0, y, Screen.width, 30), "");
        GUI.backgroundColor = new Color(0, 0, 0, 0);
        input = GUI.TextField(new Rect(10f, y + 5f, Screen.width - 20, 20), input);

    }

    private void OnReturn()
    {
        if (showConsole)
        {
            Debug.Log("handel");
            HandleInput();
            input = "";

        }
    }

    public void HandleInput()
    {
        string[] properties = input.Split(' ');

        for (int i = 0; i < commandList.Count; i++)
        {
            DebugCommandBase commandBase = commandList[i] as DebugCommandBase;

            if (input.IndexOf(commandBase.commandId, StringComparison.OrdinalIgnoreCase) >= 0)
            {

                if (commandList[i] as DebugCommand != null)
                {
                    (commandList[i] as DebugCommand).Invoke();
                }
                else if (commandList[i] as DebugCommand<int> != null)
                {
                    (commandList[i] as DebugCommand<int>).Invoke(int.Parse(properties[1]));
                }
                else if (commandList[i] as DebugCommand<string> != null)
                {

                    (commandList[i] as DebugCommand<string>).Invoke(properties[1]);

                }

            }

        }
    }


    
}
