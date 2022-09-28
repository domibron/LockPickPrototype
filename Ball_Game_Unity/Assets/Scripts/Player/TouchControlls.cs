//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Player/TouchControlls.inputactions
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

public partial class @TouchControlls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @TouchControlls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TouchControlls"",
    ""maps"": [
        {
            ""name"": ""Touch"",
            ""id"": ""9db3afd2-5714-4aa0-b3a5-dde198657013"",
            ""actions"": [
                {
                    ""name"": ""TouchInpt"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ac4c5b22-324a-4b92-a762-61069fc47962"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TouchPressed"",
                    ""type"": ""Button"",
                    ""id"": ""5a2a5d47-c9d2-4435-bc25-2dcc5e04b6c6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TouchPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""cd09ecba-4c58-417e-ab3e-49985866ac53"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""360ca003-b6f8-4d28-9776-1559b4172afe"",
                    ""path"": ""<Touchscreen>/primaryTouch"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchInpt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71050648-aa8b-4ab3-978f-d939641504fe"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f0d1de4-8925-4f86-a1eb-5fe176be2f61"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Touch
        m_Touch = asset.FindActionMap("Touch", throwIfNotFound: true);
        m_Touch_TouchInpt = m_Touch.FindAction("TouchInpt", throwIfNotFound: true);
        m_Touch_TouchPressed = m_Touch.FindAction("TouchPressed", throwIfNotFound: true);
        m_Touch_TouchPosition = m_Touch.FindAction("TouchPosition", throwIfNotFound: true);
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

    // Touch
    private readonly InputActionMap m_Touch;
    private ITouchActions m_TouchActionsCallbackInterface;
    private readonly InputAction m_Touch_TouchInpt;
    private readonly InputAction m_Touch_TouchPressed;
    private readonly InputAction m_Touch_TouchPosition;
    public struct TouchActions
    {
        private @TouchControlls m_Wrapper;
        public TouchActions(@TouchControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @TouchInpt => m_Wrapper.m_Touch_TouchInpt;
        public InputAction @TouchPressed => m_Wrapper.m_Touch_TouchPressed;
        public InputAction @TouchPosition => m_Wrapper.m_Touch_TouchPosition;
        public InputActionMap Get() { return m_Wrapper.m_Touch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchActions set) { return set.Get(); }
        public void SetCallbacks(ITouchActions instance)
        {
            if (m_Wrapper.m_TouchActionsCallbackInterface != null)
            {
                @TouchInpt.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchInpt;
                @TouchInpt.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchInpt;
                @TouchInpt.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchInpt;
                @TouchPressed.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchPressed;
                @TouchPressed.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchPressed;
                @TouchPressed.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchPressed;
                @TouchPosition.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnTouchPosition;
            }
            m_Wrapper.m_TouchActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TouchInpt.started += instance.OnTouchInpt;
                @TouchInpt.performed += instance.OnTouchInpt;
                @TouchInpt.canceled += instance.OnTouchInpt;
                @TouchPressed.started += instance.OnTouchPressed;
                @TouchPressed.performed += instance.OnTouchPressed;
                @TouchPressed.canceled += instance.OnTouchPressed;
                @TouchPosition.started += instance.OnTouchPosition;
                @TouchPosition.performed += instance.OnTouchPosition;
                @TouchPosition.canceled += instance.OnTouchPosition;
            }
        }
    }
    public TouchActions @Touch => new TouchActions(this);
    public interface ITouchActions
    {
        void OnTouchInpt(InputAction.CallbackContext context);
        void OnTouchPressed(InputAction.CallbackContext context);
        void OnTouchPosition(InputAction.CallbackContext context);
    }
}
