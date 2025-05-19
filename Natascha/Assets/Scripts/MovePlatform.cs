using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public float rightLimit = 2.5f;
    public float leftLimit = 1f;

    public float topLimit = 2.5f;
    public float bottomLimit = 1f;

    public float speed = 1f;
    private int direction = 1;
    private Vector3 movement;

    public bool horizontal = true;

    void Update()
    {
        if (horizontal == true)
        {
            if (transform.position.x > rightLimit)
            {
                direction = -1;
            }
            else if (transform.position.x < leftLimit)
            {
                direction = 1;
            }

            movement = Vector3.right * direction * speed * Time.deltaTime;
            transform.Translate(movement);
        }
        else
        {
            if (transform.position.y > topLimit)
            {
                direction = -1;
            }
            else if(transform.position.y < bottomLimit)
            {
                direction = 1;
            }
            movement = Vector3.up * direction * speed * Time.deltaTime;
            transform.Translate(movement);
        }
    }
}
