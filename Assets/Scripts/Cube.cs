using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/**
 * Manages the visibility of a game object, specifically toggling the renderer on a cube on or off. 
 * It responds to player input actions to perform the toggle operation.
 */

public class ToggleVisibility : MonoBehaviour
{
    [SerializeField] GameObject _cube; // Field for the GameObject whose visibility will be toggled

    public InputAction PlayerControls;

    private void OnEnable()
    {
        PlayerControls.Enable();
    }

    private void OnDisable()
    {
        PlayerControls.Disable();
    }

    void Update()
    {
        if (PlayerControls.WasPressedThisFrame()) // checks if the player has pressed the associated input action within the frame
        {
            ToggleCube();
        }
    }

    // This method toggles the visibility of the obj.
    // It accesses the Renderer component of the obj to check its current enabled state and then switches it to the opposite state.
    // Got help from practitioner of the course.
    void ToggleCube()
    {
        Renderer renderer = _cube.GetComponent<Renderer>();
        bool currentState = renderer.enabled;
        renderer.enabled = !currentState;
    }
}


