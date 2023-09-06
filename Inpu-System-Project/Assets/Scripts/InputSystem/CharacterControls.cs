//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Scripts/InputSystem/CharacterControls.inputactions
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

public partial class @CharacterControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CharacterControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CharacterControls"",
    ""maps"": [
        {
            ""name"": ""PlayerBehavior"",
            ""id"": ""3b9ce492-54f2-4c0e-97f2-4edf410d40d3"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""dfe5a1fb-6e39-47db-bece-8112cea55a3a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""[Keyboard] WASD"",
                    ""id"": ""d1f46224-3367-4e0a-a0fe-a5568b1b7c09"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""249db6e8-8450-42c3-9a3f-016f08283ae4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""891e5208-6750-4e1e-b6a5-4cd9ecdb0a80"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""56268bbd-7c2d-44a9-80e4-ca0b4e6a58ef"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8cb6199b-8095-4e22-a6a6-21e66507f583"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""71253613-ec40-4d43-9ee1-be466fbcd089"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerBehavior
        m_PlayerBehavior = asset.FindActionMap("PlayerBehavior", throwIfNotFound: true);
        m_PlayerBehavior_Move = m_PlayerBehavior.FindAction("Move", throwIfNotFound: true);
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

    // PlayerBehavior
    private readonly InputActionMap m_PlayerBehavior;
    private List<IPlayerBehaviorActions> m_PlayerBehaviorActionsCallbackInterfaces = new List<IPlayerBehaviorActions>();
    private readonly InputAction m_PlayerBehavior_Move;
    public struct PlayerBehaviorActions
    {
        private @CharacterControls m_Wrapper;
        public PlayerBehaviorActions(@CharacterControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerBehavior_Move;
        public InputActionMap Get() { return m_Wrapper.m_PlayerBehavior; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerBehaviorActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerBehaviorActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerBehaviorActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerBehaviorActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IPlayerBehaviorActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IPlayerBehaviorActions instance)
        {
            if (m_Wrapper.m_PlayerBehaviorActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerBehaviorActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerBehaviorActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerBehaviorActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerBehaviorActions @PlayerBehavior => new PlayerBehaviorActions(this);
    public interface IPlayerBehaviorActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
