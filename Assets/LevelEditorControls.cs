//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/LevelEditorControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @LevelEditorControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @LevelEditorControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""LevelEditorControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""a4209924-43c2-4151-9474-3cd1544c4a20"",
            ""actions"": [
                {
                    ""name"": ""MoveXZ"",
                    ""type"": ""Value"",
                    ""id"": ""346cfd43-9402-4e65-b1dc-8e5a1f210308"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveUp"",
                    ""type"": ""Value"",
                    ""id"": ""eeefd634-234d-4d9d-8eef-357dcac61df4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveDown"",
                    ""type"": ""Value"",
                    ""id"": ""2dfb1585-c07f-4cc4-92b9-a42dbf0694e2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""CycleTileBackwards"",
                    ""type"": ""Button"",
                    ""id"": ""086d5568-1364-49f4-8663-051762338789"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CycleTileForwards"",
                    ""type"": ""Button"",
                    ""id"": ""f2ed1418-ccd2-43e0-8db4-492dd6e39ca4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PlaceTile"",
                    ""type"": ""Button"",
                    ""id"": ""2e22c559-39be-4418-9aba-2e8a660e3b54"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SaveLevel"",
                    ""type"": ""Button"",
                    ""id"": ""b0e0c230-02b6-4728-b2b2-aeb575681a28"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MinimizeUi"",
                    ""type"": ""Button"",
                    ""id"": ""b0910f8f-ecd3-4cce-a3cc-144d0e24abec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""978bfe49-cc26-4a3d-ab7b-7d7a29327403"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""MoveXZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""00ca640b-d935-4593-8157-c05846ea39b3"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveXZ"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e2062cb9-1b15-46a2-838c-2f8d72a0bdd9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MoveXZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""320bffee-a40b-4347-ac70-c210eb8bc73a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MoveXZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d2581a9b-1d11-4566-b27d-b92aff5fabbc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MoveXZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fcfe95b8-67b9-4526-84b5-5d0bc98d6400"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MoveXZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8c8e490b-c610-4785-884f-f04217b23ca4"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse;Touch"",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d28589ec-f61b-4daa-b3d2-40dabb9916f8"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""143bb1cd-cc10-4eca-a2f0-a3664166fe91"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""CycleTileForwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05f6913d-c316-48b2-a6bb-e225f14c7960"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""CycleTileForwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bdd35360-10ff-4233-8f55-7fdccd4d5f3f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse;Touch"",
                    ""action"": ""MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9bfd226-fb06-4980-8108-7dd904b58c59"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86ab59dd-9b0b-42bd-bed5-5196f9bcbeac"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""CycleTileBackwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d2758be-d835-4fee-906c-d75fad9072da"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""CycleTileBackwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf23a83c-b5ce-4822-ab2a-c380835c5e93"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""PlaceTile"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22e3039f-0f8e-49a2-b500-4c4b62346daa"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""PlaceTile"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34ad872a-3a5b-4946-ab18-e05360c918ac"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""SaveLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cca8c85a-156d-491f-a3aa-1791a54d4b04"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""SaveLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb698115-b4fc-4abf-9874-4441dd2270fb"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""MinimizeUi"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c9c6c73-7017-4a8b-9c1b-aab71b72c79b"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MinimizeUi"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_MoveXZ = m_Player.FindAction("MoveXZ", throwIfNotFound: true);
        m_Player_MoveUp = m_Player.FindAction("MoveUp", throwIfNotFound: true);
        m_Player_MoveDown = m_Player.FindAction("MoveDown", throwIfNotFound: true);
        m_Player_CycleTileBackwards = m_Player.FindAction("CycleTileBackwards", throwIfNotFound: true);
        m_Player_CycleTileForwards = m_Player.FindAction("CycleTileForwards", throwIfNotFound: true);
        m_Player_PlaceTile = m_Player.FindAction("PlaceTile", throwIfNotFound: true);
        m_Player_SaveLevel = m_Player.FindAction("SaveLevel", throwIfNotFound: true);
        m_Player_MinimizeUi = m_Player.FindAction("MinimizeUi", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_MoveXZ;
    private readonly InputAction m_Player_MoveUp;
    private readonly InputAction m_Player_MoveDown;
    private readonly InputAction m_Player_CycleTileBackwards;
    private readonly InputAction m_Player_CycleTileForwards;
    private readonly InputAction m_Player_PlaceTile;
    private readonly InputAction m_Player_SaveLevel;
    private readonly InputAction m_Player_MinimizeUi;
    public struct PlayerActions
    {
        private @LevelEditorControls m_Wrapper;
        public PlayerActions(@LevelEditorControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveXZ => m_Wrapper.m_Player_MoveXZ;
        public InputAction @MoveUp => m_Wrapper.m_Player_MoveUp;
        public InputAction @MoveDown => m_Wrapper.m_Player_MoveDown;
        public InputAction @CycleTileBackwards => m_Wrapper.m_Player_CycleTileBackwards;
        public InputAction @CycleTileForwards => m_Wrapper.m_Player_CycleTileForwards;
        public InputAction @PlaceTile => m_Wrapper.m_Player_PlaceTile;
        public InputAction @SaveLevel => m_Wrapper.m_Player_SaveLevel;
        public InputAction @MinimizeUi => m_Wrapper.m_Player_MinimizeUi;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @MoveXZ.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveXZ;
                @MoveXZ.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveXZ;
                @MoveXZ.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveXZ;
                @MoveUp.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveUp;
                @MoveUp.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveUp;
                @MoveUp.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveUp;
                @MoveDown.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveDown;
                @MoveDown.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveDown;
                @MoveDown.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveDown;
                @CycleTileBackwards.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCycleTileBackwards;
                @CycleTileBackwards.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCycleTileBackwards;
                @CycleTileBackwards.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCycleTileBackwards;
                @CycleTileForwards.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCycleTileForwards;
                @CycleTileForwards.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCycleTileForwards;
                @CycleTileForwards.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCycleTileForwards;
                @PlaceTile.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlaceTile;
                @PlaceTile.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlaceTile;
                @PlaceTile.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlaceTile;
                @SaveLevel.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSaveLevel;
                @SaveLevel.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSaveLevel;
                @SaveLevel.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSaveLevel;
                @MinimizeUi.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMinimizeUi;
                @MinimizeUi.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMinimizeUi;
                @MinimizeUi.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMinimizeUi;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveXZ.started += instance.OnMoveXZ;
                @MoveXZ.performed += instance.OnMoveXZ;
                @MoveXZ.canceled += instance.OnMoveXZ;
                @MoveUp.started += instance.OnMoveUp;
                @MoveUp.performed += instance.OnMoveUp;
                @MoveUp.canceled += instance.OnMoveUp;
                @MoveDown.started += instance.OnMoveDown;
                @MoveDown.performed += instance.OnMoveDown;
                @MoveDown.canceled += instance.OnMoveDown;
                @CycleTileBackwards.started += instance.OnCycleTileBackwards;
                @CycleTileBackwards.performed += instance.OnCycleTileBackwards;
                @CycleTileBackwards.canceled += instance.OnCycleTileBackwards;
                @CycleTileForwards.started += instance.OnCycleTileForwards;
                @CycleTileForwards.performed += instance.OnCycleTileForwards;
                @CycleTileForwards.canceled += instance.OnCycleTileForwards;
                @PlaceTile.started += instance.OnPlaceTile;
                @PlaceTile.performed += instance.OnPlaceTile;
                @PlaceTile.canceled += instance.OnPlaceTile;
                @SaveLevel.started += instance.OnSaveLevel;
                @SaveLevel.performed += instance.OnSaveLevel;
                @SaveLevel.canceled += instance.OnSaveLevel;
                @MinimizeUi.started += instance.OnMinimizeUi;
                @MinimizeUi.performed += instance.OnMinimizeUi;
                @MinimizeUi.canceled += instance.OnMinimizeUi;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMoveXZ(InputAction.CallbackContext context);
        void OnMoveUp(InputAction.CallbackContext context);
        void OnMoveDown(InputAction.CallbackContext context);
        void OnCycleTileBackwards(InputAction.CallbackContext context);
        void OnCycleTileForwards(InputAction.CallbackContext context);
        void OnPlaceTile(InputAction.CallbackContext context);
        void OnSaveLevel(InputAction.CallbackContext context);
        void OnMinimizeUi(InputAction.CallbackContext context);
    }
}
