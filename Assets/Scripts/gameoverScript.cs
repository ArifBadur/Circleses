using UnityEngine;

public class gameoverScript : MonoBehaviour
{
    public GameObject textSkor;
    public GameObject scorps;
    public GameObject GameOverP;
    public GameObject particleObject;
    public GameObject VariableJoystick;
    public GameObject cirles;
    bool particle = false;

    void Start()
    {
        ParticleEffect();
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "bomb")
        {
            GameOverP.SetActive(true);
            Destroy(scorps);
            Destroy(cirles);
            Destroy(VariableJoystick);
            Destroy(textSkor);
            particle = true;
            particleObject.SetActive(true);
        }/*
        if (collider.gameObject.tag == "sball")
        {
            //Destroy(gameObject);
            //particle = true;
            //particleObject.SetActive(true);
            //SceneManager.LoadScene(0);
        }
        if (collider.gameObject.tag == "mball")
        {
            //Destroy(gameObject);
            particle = true;
            particleObject.SetActive(true);
            //SceneManager.LoadScene(0);
        }
        if (collider.gameObject.tag == "lball")
        {
            //Destroy(gameObject);
            particle = true;
            particleObject.SetActive(true);
            //SceneManager.LoadScene(0);
        }
        else
        {
            //particle = false;
            particleObject.SetActive(false);
        }*/

    }

    private void ParticleEffect()
    {
        if (!particle)
        {
            particleObject.SetActive(false);
        }
        else
        {
            particleObject.SetActive(true);
        }
    }
}
