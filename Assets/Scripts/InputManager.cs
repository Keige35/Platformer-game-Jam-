using UnityEngine;

public class InputManager : MonoBehaviour
{
    private float cooldownTime = 0;
    public Vector3 MoveDirection { get; private set; }
    public float MoveDirectionHorizontal { get; private set; }
    public bool IsJumping { get; private set; }
    public bool IsRolling { get; private set; }
    public bool IsDashing {  get; private set; }

    void Update()
    {
        IsRolling = Input.GetKeyDown(KeyCode.LeftControl);
        IsJumping = Input.GetKeyDown(KeyCode.Space);
        IsDashing = Input.GetKeyDown(KeyCode.LeftShift);
        MoveDirectionHorizontal = Input.GetAxis("Horizontal");
        MoveDirection = new Vector3(0, 0, MoveDirectionHorizontal);      
    }
}