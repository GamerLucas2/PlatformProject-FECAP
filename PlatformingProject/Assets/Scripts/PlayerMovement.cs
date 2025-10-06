using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    InputSystem_Actions inputSystemActions;
    InputAction move;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputSystemActions = new InputSystem_Actions();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
