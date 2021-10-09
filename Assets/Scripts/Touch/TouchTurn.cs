using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTurn : MonoBehaviour
{
    public bool Lb, Mb, Sb;
    public GameObject PlayerL, PlayerM, PlayerS;

    void Start()
    {
        //StartCoroutine(GK());
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch parmak = Input.GetTouch(0);

            if (parmak.deltaPosition.y > 50.0f)
            {
                    PlayerL.SetActive(false);
                    if (Sb == false && Lb == true)
                    {
                        //GK();
                        PlayerM.SetActive(true);
                        PlayerS.SetActive(false);
                        Mb = true;
                        Sb = false;
                        Lb = false;

                    }
                    else if (Mb == true && Lb == false)
                    {
                        //GK();
                        PlayerS.SetActive(true);
                        PlayerM.SetActive(false);
                        Sb = true;
                        Lb = false;
                        Mb = false;

                    }
                }
            if (parmak.deltaPosition.y < -50.0f)
            {
                    PlayerS.SetActive(false);
                    if (Mb == true && Sb == false)
                    {
                        //GK();
                        PlayerL.SetActive(true);
                        PlayerM.SetActive(false);
                        Lb = true;
                        Mb = false;
                        Sb = false;

                    }
                    else if (Sb == true && Lb == false)
                    {
                        //GK();
                        PlayerL.SetActive(false);
                        PlayerM.SetActive(true);
                        Mb = true;
                        Sb = false;
                        Lb = false;

                    }
                }
            
        }

    }
    /*
    IEnumerator GK()
    {
        yield return new WaitForSeconds(3f);
    }
    */
}

