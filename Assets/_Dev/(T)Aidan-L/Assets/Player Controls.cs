//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/_Dev/(T)Aidan-L/Assets/Player Controls.inputactions
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

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Controls"",
    ""maps"": [
        {
            ""name"": ""Fighting"",
            ""id"": ""4eb92c4b-13d5-44ec-b4e9-ab8659e46dbb"",
            ""actions"": [
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""723b49e7-5b55-45d1-9c4e-38878a4a7d84"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dodge"",
                    ""type"": ""Button"",
                    ""id"": ""7a7dd7e9-9ad8-4642-861d-1331ff24046a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Charge"",
                    ""type"": ""Button"",
                    ""id"": ""3e7e26d6-93e3-4c19-be7a-d1962957fbd0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9a510098-6a24-4719-9d5e-9076ed2e1028"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player1;Player2"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ca24f74-5328-4ead-bb00-500081457e36"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player1;Player2"",
                    ""action"": ""Charge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4eca943d-7d5f-4181-a4c8-88951000e86f"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player1;Player2"",
                    ""action"": ""Dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Player1"",
            ""bindingGroup"": ""Player1"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Player2"",
            ""bindingGroup"": ""Player2"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Fighting
        m_Fighting = asset.FindActionMap("Fighting", throwIfNotFound: true);
        m_Fighting_Attack = m_Fighting.FindAction("Attack", throwIfNotFound: true);
        m_Fighting_Dodge = m_Fighting.FindAction("Dodge", throwIfNotFound: true);
        m_Fighting_Charge = m_Fighting.FindAction("Charge", throwIfNotFound: true);
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

    // Fighting
    private readonly InputActionMap m_Fighting;
    private IFightingActions m_FightingActionsCallbackInterface;
    private readonly InputAction m_Fighting_Attack;
    private readonly InputAction m_Fighting_Dodge;
    private readonly InputAction m_Fighting_Charge;
    public struct FightingActions
    {
        private @PlayerControls m_Wrapper;
        public FightingActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Attack => m_Wrapper.m_Fighting_Attack;
        public InputAction @Dodge => m_Wrapper.m_Fighting_Dodge;
        public InputAction @Charge => m_Wrapper.m_Fighting_Charge;
        public InputActionMap Get() { return m_Wrapper.m_Fighting; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FightingActions set) { return set.Get(); }
        public void SetCallbacks(IFightingActions instance)
        {
            if (m_Wrapper.m_FightingActionsCallbackInterface != null)
            {
                @Attack.started -= m_Wrapper.m_FightingActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_FightingActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_FightingActionsCallbackInterface.OnAttack;
                @Dodge.started -= m_Wrapper.m_FightingActionsCallbackInterface.OnDodge;
                @Dodge.performed -= m_Wrapper.m_FightingActionsCallbackInterface.OnDodge;
                @Dodge.canceled -= m_Wrapper.m_FightingActionsCallbackInterface.OnDodge;
                @Charge.started -= m_Wrapper.m_FightingActionsCallbackInterface.OnCharge;
                @Charge.performed -= m_Wrapper.m_FightingActionsCallbackInterface.OnCharge;
                @Charge.canceled -= m_Wrapper.m_FightingActionsCallbackInterface.OnCharge;
            }
            m_Wrapper.m_FightingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Dodge.started += instance.OnDodge;
                @Dodge.performed += instance.OnDodge;
                @Dodge.canceled += instance.OnDodge;
                @Charge.started += instance.OnCharge;
                @Charge.performed += instance.OnCharge;
                @Charge.canceled += instance.OnCharge;
            }
        }
    }
    public FightingActions @Fighting => new FightingActions(this);
    private int m_Player1SchemeIndex = -1;
    public InputControlScheme Player1Scheme
    {
        get
        {
            if (m_Player1SchemeIndex == -1) m_Player1SchemeIndex = asset.FindControlSchemeIndex("Player1");
            return asset.controlSchemes[m_Player1SchemeIndex];
        }
    }
    private int m_Player2SchemeIndex = -1;
    public InputControlScheme Player2Scheme
    {
        get
        {
            if (m_Player2SchemeIndex == -1) m_Player2SchemeIndex = asset.FindControlSchemeIndex("Player2");
            return asset.controlSchemes[m_Player2SchemeIndex];
        }
    }
    public interface IFightingActions
    {
        void OnAttack(InputAction.CallbackContext context);
        void OnDodge(InputAction.CallbackContext context);
        void OnCharge(InputAction.CallbackContext context);
    }
}
