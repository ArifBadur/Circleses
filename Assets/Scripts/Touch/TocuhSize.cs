using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TocuhSize : MonoBehaviour
{
    public float speed;
    Rigidbody rigid;

    void Update()
    {
        speed++;
        if (Input.touchCount > 0)
        {
            Touch parmak = Input.GetTouch(0);

            if (parmak.deltaPosition.x > 50.0f )
            {
                transform.Rotate(new Vector3(0f, 0f, speed) * Time.deltaTime);
            }
            if (parmak.deltaPosition.x < -50.0f)
            {
                transform.Rotate(new Vector3(0f, 0f, -speed) * Time.deltaTime);
            }
        }
    }
}