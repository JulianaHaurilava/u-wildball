using TMPro;
using UnityEngine;

public class ShowInstructions : MonoBehaviour
{
    [SerializeField]
    private GameObject instructionsPanel;
    [SerializeField]
    private TMP_Text instructionsText;
    [SerializeField]
    private string instructions;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            instructionsText.text = instructions;
            SetPanelState(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            SetPanelState(false);
        }
    }

    private void SetPanelState(bool state)
    {
        instructionsPanel.SetActive(state);

    }
}
