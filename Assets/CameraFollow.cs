using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    Vector3 offset = new Vector3(0, 2, -6);

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(
            transform.position,
            player.position + offset,
            5f * Time.deltaTime
        );
    }
}