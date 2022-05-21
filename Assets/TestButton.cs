using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestButton : MonoBehaviour
{
    [SerializeField]
    InputActionReference inputActionReference_UISwitcher;

    private void OnEnable()
    {
        inputActionReference_UISwitcher.action.performed += PrintSomething;
    }
    private void OnDisable()
    {
        inputActionReference_UISwitcher.action.performed -= PrintSomething;
    }

    private void PrintSomething(InputAction.CallbackContext obj)
    {
        print("Hi");
    }
}
