using UnityEngine;

public class CoinCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMovement player =
                other.GetComponent<PlayerMovement>();

            player.AddScore();

            Destroy(gameObject);
        }
    }
}