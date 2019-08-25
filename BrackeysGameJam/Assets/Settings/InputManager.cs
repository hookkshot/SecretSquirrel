// GENERATED AUTOMATICALLY FROM 'Assets/Settings/InputManager.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class InputManager : IInputActionCollection
{
    private InputActionAsset asset;
    public InputManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputManager"",
    ""maps"": [
        {
            ""name"": ""Menu"",
            ""id"": ""74171afd-b5a6-4783-9db3-ca309d41b35b"",
            ""actions"": [
                {
                    ""name"": ""Accept"",
                    ""type"": ""Button"",
                    ""id"": ""4e5bdf3c-73f4-4002-8cf5-1c22ec20a70f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""a299cbb4-6a27-4297-8a83-99da7a44b9de"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""2d787f25-db9b-47cc-8ea1-aee22530cf64"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""2d44d439-a5bf-4107-8769-cb889f7a362a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5185d467-d4cb-4f1a-bea8-803852278029"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""efa2b32b-0db0-48ef-9d4d-27b4325dc53b"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b66c804-2bbc-4fba-8f00-3e18a0d6444e"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a83dd242-6417-4e11-8ed4-64655ca162d3"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c9ea694-ab3d-4a0a-b989-347c09cf181e"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Game"",
            ""id"": ""eb137a81-f8ba-47d7-ae65-52b646989a66"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""1e9c4ab7-f56b-4657-a316-3a4e6318170f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""68ebef03-d638-420d-b4e9-0e1525dcbf62"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""5429d8cf-de25-46f4-9538-7a5ab7a79be3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action1"",
                    ""type"": ""Button"",
                    ""id"": ""b75ec504-0fb8-44a9-8e8a-a1dead412d78"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action2"",
                    ""type"": ""Button"",
                    ""id"": ""997bdae2-ea8f-4da0-aa4e-7021648416c4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action3"",
                    ""type"": ""Button"",
                    ""id"": ""70037bf3-f05e-4e6a-8016-da13e630b505"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action4"",
                    ""type"": ""Button"",
                    ""id"": ""76f2e710-0c66-4949-be52-9deb4137dcab"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4424dca8-df25-4142-8258-3e1d95dd0c84"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5654eb7-6fb4-4e9c-8b59-d466eba315f7"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf99b814-6637-4df3-854b-2220004bf69f"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d49804cd-236b-46af-9c30-e0e0bf1eae9b"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c9d9ec0-e870-4d82-8b5e-a52ecae44f67"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3dc02d02-8b6b-4081-b5f6-d7d8af7a33c2"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12d7bc49-47ef-4af6-bf8c-d428c20146e8"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""873128c8-a811-4b79-89ac-09195a0378ac"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Menu
        m_Menu = asset.GetActionMap("Menu");
        m_Menu_Accept = m_Menu.GetAction("Accept");
        m_Menu_Cancel = m_Menu.GetAction("Cancel");
        m_Menu_Move = m_Menu.GetAction("Move");
        m_Menu_Start = m_Menu.GetAction("Start");
        // Game
        m_Game = asset.GetActionMap("Game");
        m_Game_Move = m_Game.GetAction("Move");
        m_Game_Start = m_Game.GetAction("Start");
        m_Game_Back = m_Game.GetAction("Back");
        m_Game_Action1 = m_Game.GetAction("Action1");
        m_Game_Action2 = m_Game.GetAction("Action2");
        m_Game_Action3 = m_Game.GetAction("Action3");
        m_Game_Action4 = m_Game.GetAction("Action4");
    }

    ~InputManager()
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

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Accept;
    private readonly InputAction m_Menu_Cancel;
    private readonly InputAction m_Menu_Move;
    private readonly InputAction m_Menu_Start;
    public struct MenuActions
    {
        private InputManager m_Wrapper;
        public MenuActions(InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accept => m_Wrapper.m_Menu_Accept;
        public InputAction @Cancel => m_Wrapper.m_Menu_Cancel;
        public InputAction @Move => m_Wrapper.m_Menu_Move;
        public InputAction @Start => m_Wrapper.m_Menu_Start;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                Accept.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnAccept;
                Accept.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnAccept;
                Accept.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnAccept;
                Cancel.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnCancel;
                Cancel.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnCancel;
                Cancel.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnCancel;
                Move.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMove;
                Start.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnStart;
                Start.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnStart;
                Start.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnStart;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                Accept.started += instance.OnAccept;
                Accept.performed += instance.OnAccept;
                Accept.canceled += instance.OnAccept;
                Cancel.started += instance.OnCancel;
                Cancel.performed += instance.OnCancel;
                Cancel.canceled += instance.OnCancel;
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
                Start.started += instance.OnStart;
                Start.performed += instance.OnStart;
                Start.canceled += instance.OnStart;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // Game
    private readonly InputActionMap m_Game;
    private IGameActions m_GameActionsCallbackInterface;
    private readonly InputAction m_Game_Move;
    private readonly InputAction m_Game_Start;
    private readonly InputAction m_Game_Back;
    private readonly InputAction m_Game_Action1;
    private readonly InputAction m_Game_Action2;
    private readonly InputAction m_Game_Action3;
    private readonly InputAction m_Game_Action4;
    public struct GameActions
    {
        private InputManager m_Wrapper;
        public GameActions(InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Game_Move;
        public InputAction @Start => m_Wrapper.m_Game_Start;
        public InputAction @Back => m_Wrapper.m_Game_Back;
        public InputAction @Action1 => m_Wrapper.m_Game_Action1;
        public InputAction @Action2 => m_Wrapper.m_Game_Action2;
        public InputAction @Action3 => m_Wrapper.m_Game_Action3;
        public InputAction @Action4 => m_Wrapper.m_Game_Action4;
        public InputActionMap Get() { return m_Wrapper.m_Game; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
        public void SetCallbacks(IGameActions instance)
        {
            if (m_Wrapper.m_GameActionsCallbackInterface != null)
            {
                Move.started -= m_Wrapper.m_GameActionsCallbackInterface.OnMove;
                Move.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnMove;
                Move.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnMove;
                Start.started -= m_Wrapper.m_GameActionsCallbackInterface.OnStart;
                Start.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnStart;
                Start.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnStart;
                Back.started -= m_Wrapper.m_GameActionsCallbackInterface.OnBack;
                Back.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnBack;
                Back.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnBack;
                Action1.started -= m_Wrapper.m_GameActionsCallbackInterface.OnAction1;
                Action1.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnAction1;
                Action1.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnAction1;
                Action2.started -= m_Wrapper.m_GameActionsCallbackInterface.OnAction2;
                Action2.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnAction2;
                Action2.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnAction2;
                Action3.started -= m_Wrapper.m_GameActionsCallbackInterface.OnAction3;
                Action3.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnAction3;
                Action3.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnAction3;
                Action4.started -= m_Wrapper.m_GameActionsCallbackInterface.OnAction4;
                Action4.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnAction4;
                Action4.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnAction4;
            }
            m_Wrapper.m_GameActionsCallbackInterface = instance;
            if (instance != null)
            {
                Move.started += instance.OnMove;
                Move.performed += instance.OnMove;
                Move.canceled += instance.OnMove;
                Start.started += instance.OnStart;
                Start.performed += instance.OnStart;
                Start.canceled += instance.OnStart;
                Back.started += instance.OnBack;
                Back.performed += instance.OnBack;
                Back.canceled += instance.OnBack;
                Action1.started += instance.OnAction1;
                Action1.performed += instance.OnAction1;
                Action1.canceled += instance.OnAction1;
                Action2.started += instance.OnAction2;
                Action2.performed += instance.OnAction2;
                Action2.canceled += instance.OnAction2;
                Action3.started += instance.OnAction3;
                Action3.performed += instance.OnAction3;
                Action3.canceled += instance.OnAction3;
                Action4.started += instance.OnAction4;
                Action4.performed += instance.OnAction4;
                Action4.canceled += instance.OnAction4;
            }
        }
    }
    public GameActions @Game => new GameActions(this);
    public interface IMenuActions
    {
        void OnAccept(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
    }
    public interface IGameActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
        void OnAction1(InputAction.CallbackContext context);
        void OnAction2(InputAction.CallbackContext context);
        void OnAction3(InputAction.CallbackContext context);
        void OnAction4(InputAction.CallbackContext context);
    }
}
