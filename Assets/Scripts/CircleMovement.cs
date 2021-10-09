using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    public float speed;
    Rigidbody rigid;

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0f, 0f, speed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0f, 0f, -speed) * Time.deltaTime);
        }
    }
}
