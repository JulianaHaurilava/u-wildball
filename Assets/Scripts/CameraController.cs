using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Vector3 offset;
    [SerializeField] Transform player;

    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
