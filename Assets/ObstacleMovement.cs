using TreeEditor;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed = 2f;
    bool movingRight = true;

    void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (transform.position.x > 3)
        {
            movingRight = false;
        }

        if (transform.position.x < -3)
        {
            movingRight = true;
        }
    }

}
