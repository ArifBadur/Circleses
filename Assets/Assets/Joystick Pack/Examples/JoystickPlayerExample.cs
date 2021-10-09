using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public bool Lb, Mb, Sb;
    public GameObject PlayerL, PlayerM, PlayerS;
    public float speed;
    public Joystick joystick;
    public float rotateHorizontal;
    public void FixedUpdate()
    {
        rotateHorizontal = joystick.Horizontal * speed;
        transform.Rotate(0, -rotateHorizontal, 0);
    }
    void Update()
    {
        if (joystick.Vertical > 0.9)
        {   
            PlayerL.SetActive(false);
            PlayerM.SetActive(false);
            PlayerS.SetActive(true);
            Lb = false;
            Mb = false;
            Sb = true;
            speed = 0;
        }

        if (joystick.Vertical == 0)
        {
            PlayerL.SetActive(false);
            PlayerM.SetActive(true);
            PlayerS.SetActive(false);
            Sb = false;
            Lb = false;
            Mb = true;
            speed = 4;
        }

        if (joystick.Vertical < -0.9)
        {
            PlayerL.SetActive(true);
            PlayerM.SetActive(false);
            PlayerS.SetActive(false);
            Sb = false;
            Lb = true;
            Mb = false;
            speed = 0;
        }
    }
}