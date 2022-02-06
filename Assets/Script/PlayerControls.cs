// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerAction"",
            ""id"": ""8aed7a38-8521-4769-ac80-1f03a2ca02de"",
            ""actions"": [
                {
                    ""name"": ""Teleport"",
                    ""type"": ""Button"",
                    ""id"": ""d24ff686-4e26-4ff6-9c96-84a1d198bd31"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""SlowTap(duration=0.01,pressPoint=0.01)""
                },
                {
                    ""name"": ""SuperTeleport"",
                    ""type"": ""Button"",
                    ""id"": ""a958d84d-dfe2-4c88-9f31-b0d3dc20087d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""SlowTap(duration=0.01,pressPoint=0.01)""
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""6749038f-3e2e-4d9e-a813-893a0a57d9f2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraMovement"",
                    ""type"": ""Button"",
                    ""id"": ""42e25212-7e24-41cc-8ae4-ca16227d9290"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NextLine"",
                    ""type"": ""Button"",
                    ""id"": ""63060bb6-8696-493c-a80d-bf80379f4f70"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""OpenBigMap"",
                    ""type"": ""Button"",
                    ""id"": ""fefd6011-8fe1-4070-99e2-e57560f5348e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StartConversation"",
                    ""type"": ""Button"",
                    ""id"": ""f50f15f4-fdb9-45fa-8676-ab391a26ffbc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a12257a8-f559-43d5-8986-c99b9fed890d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Teleport"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b507eb8-7564-47ce-81d7-ae766c861eb9"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Teleport"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be5cf101-e9d4-4602-8548-3fe22fd77e03"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""002bc828-fb6d-4790-bcef-d11f858b5c13"",
                    ""path"": ""<Mouse>/Delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""4f9212c5-4cca-47b5-be82-d72f418158e6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bf86cf83-b804-4e48-aca2-1282fbe40da7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8391a6a4-5465-4f1a-b3dc-1ccfd9519de1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a7144d6c-ea15-44b5-af7b-5f7663a1add4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d0c72577-e595-4d70-ad53-b8d34f4c2cec"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b9303621-6881-4c7c-8352-6844f82f3c07"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""287f82ab-c3b5-4cf1-b37d-4de5e2630b76"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextLine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e863097-c752-4e23-af84-2a8449d06709"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextLine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3343568f-66a4-4898-8383-2a40dbb49710"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenBigMap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5abd8975-960a-4b62-8872-b718b1fcedc9"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenBigMap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""886f81fb-c5c5-45af-9b0f-35b83ab1e34a"",
                    ""path"": ""<DualShockGamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SuperTeleport"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""456818a9-181a-414c-b6e6-e6e9f6c3ff21"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartConversation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Debug"",
            ""id"": ""03d94444-ea8d-443d-b7b2-ba71dd721415"",
            ""actions"": [
                {
                    ""name"": ""ToggleDebug"",
                    ""type"": ""Button"",
                    ""id"": ""6ce10f88-789c-48eb-9959-d2cb5f228f01"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ReturnDebug"",
                    ""type"": ""Button"",
                    ""id"": ""dac3b100-11bf-49a9-b7de-c2aba27b4102"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9ea066ba-87b9-4429-b28e-322e35734268"",
                    ""path"": ""<Keyboard>/slash"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleDebug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""129f2692-cbfb-4456-84db-205c8d0a00cc"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ReturnDebug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""96ca4498-2f20-4bc9-a41f-65a75384c922"",
            ""actions"": [
                {
                    ""name"": ""OpenUIPage"",
                    ""type"": ""Button"",
                    ""id"": ""431729bd-2424-4323-a1f5-b532c9d5e6dc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""664664f2-6118-4499-945e-3871cd37edee"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenUIPage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38a3e01c-e271-4776-ae72-72348cbcb49d"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenUIPage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerAction
        m_PlayerAction = asset.FindActionMap("PlayerAction", throwIfNotFound: true);
        m_PlayerAction_Teleport = m_PlayerAction.FindAction("Teleport", throwIfNotFound: true);
        m_PlayerAction_SuperTeleport = m_PlayerAction.FindAction("SuperTeleport", throwIfNotFound: true);
        m_PlayerAction_Movement = m_PlayerAction.FindAction("Movement", throwIfNotFound: true);
        m_PlayerAction_CameraMovement = m_PlayerAction.FindAction("CameraMovement", throwIfNotFound: true);
        m_PlayerAction_NextLine = m_PlayerAction.FindAction("NextLine", throwIfNotFound: true);
        m_PlayerAction_OpenBigMap = m_PlayerAction.FindAction("OpenBigMap", throwIfNotFound: true);
        m_PlayerAction_StartConversation = m_PlayerAction.FindAction("StartConversation", throwIfNotFound: true);
        // Debug
        m_Debug = asset.FindActionMap("Debug", throwIfNotFound: true);
        m_Debug_ToggleDebug = m_Debug.FindAction("ToggleDebug", throwIfNotFound: true);
        m_Debug_ReturnDebug = m_Debug.FindAction("ReturnDebug", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_OpenUIPage = m_UI.FindAction("OpenUIPage", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // PlayerAction
    private readonly InputActionMap m_PlayerAction;
    private IPlayerActionActions m_PlayerActionActionsCallbackInterface;
    private readonly InputAction m_PlayerAction_Teleport;
    private readonly InputAction m_PlayerAction_SuperTeleport;
    private readonly InputAction m_PlayerAction_Movement;
    private readonly InputAction m_PlayerAction_CameraMovement;
    private readonly InputAction m_PlayerAction_NextLine;
    private readonly InputAction m_PlayerAction_OpenBigMap;
    private readonly InputAction m_PlayerAction_StartConversation;
    public struct PlayerActionActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActionActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Teleport => m_Wrapper.m_PlayerAction_Teleport;
        public InputAction @SuperTeleport => m_Wrapper.m_PlayerAction_SuperTeleport;
        public InputAction @Movement => m_Wrapper.m_PlayerAction_Movement;
        public InputAction @CameraMovement => m_Wrapper.m_PlayerAction_CameraMovement;
        public InputAction @NextLine => m_Wrapper.m_PlayerAction_NextLine;
        public InputAction @OpenBigMap => m_Wrapper.m_PlayerAction_OpenBigMap;
        public InputAction @StartConversation => m_Wrapper.m_PlayerAction_StartConversation;
        public InputActionMap Get() { return m_Wrapper.m_PlayerAction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionActions instance)
        {
            if (m_Wrapper.m_PlayerActionActionsCallbackInterface != null)
            {
                @Teleport.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnTeleport;
                @Teleport.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnTeleport;
                @Teleport.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnTeleport;
                @SuperTeleport.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnSuperTeleport;
                @SuperTeleport.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnSuperTeleport;
                @SuperTeleport.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnSuperTeleport;
                @Movement.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnMovement;
                @CameraMovement.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnCameraMovement;
                @CameraMovement.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnCameraMovement;
                @CameraMovement.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnCameraMovement;
                @NextLine.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnNextLine;
                @NextLine.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnNextLine;
                @NextLine.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnNextLine;
                @OpenBigMap.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnOpenBigMap;
                @OpenBigMap.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnOpenBigMap;
                @OpenBigMap.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnOpenBigMap;
                @StartConversation.started -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnStartConversation;
                @StartConversation.performed -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnStartConversation;
                @StartConversation.canceled -= m_Wrapper.m_PlayerActionActionsCallbackInterface.OnStartConversation;
            }
            m_Wrapper.m_PlayerActionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Teleport.started += instance.OnTeleport;
                @Teleport.performed += instance.OnTeleport;
                @Teleport.canceled += instance.OnTeleport;
                @SuperTeleport.started += instance.OnSuperTeleport;
                @SuperTeleport.performed += instance.OnSuperTeleport;
                @SuperTeleport.canceled += instance.OnSuperTeleport;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @CameraMovement.started += instance.OnCameraMovement;
                @CameraMovement.performed += instance.OnCameraMovement;
                @CameraMovement.canceled += instance.OnCameraMovement;
                @NextLine.started += instance.OnNextLine;
                @NextLine.performed += instance.OnNextLine;
                @NextLine.canceled += instance.OnNextLine;
                @OpenBigMap.started += instance.OnOpenBigMap;
                @OpenBigMap.performed += instance.OnOpenBigMap;
                @OpenBigMap.canceled += instance.OnOpenBigMap;
                @StartConversation.started += instance.OnStartConversation;
                @StartConversation.performed += instance.OnStartConversation;
                @StartConversation.canceled += instance.OnStartConversation;
            }
        }
    }
    public PlayerActionActions @PlayerAction => new PlayerActionActions(this);

    // Debug
    private readonly InputActionMap m_Debug;
    private IDebugActions m_DebugActionsCallbackInterface;
    private readonly InputAction m_Debug_ToggleDebug;
    private readonly InputAction m_Debug_ReturnDebug;
    public struct DebugActions
    {
        private @PlayerControls m_Wrapper;
        public DebugActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ToggleDebug => m_Wrapper.m_Debug_ToggleDebug;
        public InputAction @ReturnDebug => m_Wrapper.m_Debug_ReturnDebug;
        public InputActionMap Get() { return m_Wrapper.m_Debug; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugActions set) { return set.Get(); }
        public void SetCallbacks(IDebugActions instance)
        {
            if (m_Wrapper.m_DebugActionsCallbackInterface != null)
            {
                @ToggleDebug.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnToggleDebug;
                @ToggleDebug.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnToggleDebug;
                @ToggleDebug.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnToggleDebug;
                @ReturnDebug.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnReturnDebug;
                @ReturnDebug.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnReturnDebug;
                @ReturnDebug.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnReturnDebug;
            }
            m_Wrapper.m_DebugActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ToggleDebug.started += instance.OnToggleDebug;
                @ToggleDebug.performed += instance.OnToggleDebug;
                @ToggleDebug.canceled += instance.OnToggleDebug;
                @ReturnDebug.started += instance.OnReturnDebug;
                @ReturnDebug.performed += instance.OnReturnDebug;
                @ReturnDebug.canceled += instance.OnReturnDebug;
            }
        }
    }
    public DebugActions @Debug => new DebugActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_OpenUIPage;
    public struct UIActions
    {
        private @PlayerControls m_Wrapper;
        public UIActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @OpenUIPage => m_Wrapper.m_UI_OpenUIPage;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @OpenUIPage.started -= m_Wrapper.m_UIActionsCallbackInterface.OnOpenUIPage;
                @OpenUIPage.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnOpenUIPage;
                @OpenUIPage.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnOpenUIPage;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @OpenUIPage.started += instance.OnOpenUIPage;
                @OpenUIPage.performed += instance.OnOpenUIPage;
                @OpenUIPage.canceled += instance.OnOpenUIPage;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IPlayerActionActions
    {
        void OnTeleport(InputAction.CallbackContext context);
        void OnSuperTeleport(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnCameraMovement(InputAction.CallbackContext context);
        void OnNextLine(InputAction.CallbackContext context);
        void OnOpenBigMap(InputAction.CallbackContext context);
        void OnStartConversation(InputAction.CallbackContext context);
    }
    public interface IDebugActions
    {
        void OnToggleDebug(InputAction.CallbackContext context);
        void OnReturnDebug(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnOpenUIPage(InputAction.CallbackContext context);
    }
}
