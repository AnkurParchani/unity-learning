using UnityEngine;

public class CoinCollider : MonoBehaviour
{
    int score = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Coin")
        {
            score++;
            Debug.Log("Score: " + score);
            Destroy(other.gameObject);
        }
    }
}
