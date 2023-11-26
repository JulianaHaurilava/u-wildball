using TMPro;
using UnityEngine;

[RequireComponent(typeof(UpPlatforms))]
public class ShowInstructions : MonoBehaviour
{
    [SerializeField]
    private GameObject instructionsPanel;
    [SerializeField]
    private TMP_Text instructionsText;
    [SerializeField]
    private string instructions;

    private UpPlatforms upPlatforms;
    private bool playerCollides;

    [Header("Keybinds")]
    [SerializeField] KeyCode activatePlatformsKey = KeyCode.E;

    private void Start()
    {
        upPlatforms = GetComponent<UpPlatforms>();
        playerCollides = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(activatePlatformsKey) && playerCollides)
        {
            upPlatforms.ActivatePlatforms();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            instructionsText.text = instructions;
            SetPanelState(true);
            playerCollides = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SetPanelState(false);
            playerCollides = false;
        }
    }

    private void SetPanelState(bool state)
    {
        instructionsPanel.SetActive(state);

    }
}
