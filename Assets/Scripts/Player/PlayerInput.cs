using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerInput : MonoBehaviour
{
    private const string HORIZONTAL_AXIS = "Horizontal";
    private const string VERTICAL_AXIS = "Vertical";

    private Vector3 input;

    private PlayerMovement playerMovement;

    [Header("Keybinds")]
    [SerializeField] KeyCode jumpKey = KeyCode.Space;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw(HORIZONTAL_AXIS);
        float vertical = Input.GetAxisRaw(VERTICAL_AXIS);

        input = new Vector3(horizontal, 0, vertical).normalized;

        if (Input.GetKey(jumpKey))
        {
            playerMovement.Jump();
        }
    }
    private void FixedUpdate()
    {
        playerMovement.MovePlayer(input);
    }
}
