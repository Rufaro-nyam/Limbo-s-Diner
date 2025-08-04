using UnityEngine;

public class InputManager : MonoBehaviour
{

    PlayerInput controls;
    PlayerInput.MovementActions groundmovement;

    [SerializeField] PlayerMovement movement;
    [SerializeField] Hands hands;



    Vector2 mouseInput;
    Vector2 horizontal_input;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        controls = new PlayerInput();
        groundmovement = controls.Movement;

        groundmovement.Horizontal.performed += ctx => horizontal_input = ctx.ReadValue<Vector2>();
        groundmovement.Jump.performed += _ => movement.onjump_pressed();

        //mouse
        groundmovement.MouseX.performed += ctx => mouseInput.x = ctx.ReadValue<float>();
        groundmovement.MouseY.performed += ctx => mouseInput.y = ctx.ReadValue<float>();

        //hands
        groundmovement.Interact.performed += _ => hands.shoot();
    }


    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void Update()
    {
        movement.recieveInput(horizontal_input);
        movement.recieveMouseInput(mouseInput);
    }

}
