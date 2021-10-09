using UnityEngine;
using UnityEngine.UI;

public class SkorpSC : MonoBehaviour
{
    public GameObject PlayerL, PlayerM, PlayerS;
    public bool Sm, Mm, Lm;
    public GameObject textSkor;
    private Text Skor;
    public Text highScore;
    public int sayac = 0;

    public float speed;
    public Joystick joystick;
    public float rotateHorizontal;


    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        Skor = textSkor.GetComponent<Text>();
    }

    void Update()
    {
        if (joystick.Vertical > 0.9)
        {
            PlayerL.SetActive(false);
            PlayerM.SetActive(false);
            PlayerS.SetActive(true);
            Lm = false;
            Mm = false;
            Sm = true;
        }

        if (joystick.Vertical == 0)
        {
            PlayerL.SetActive(false);
            PlayerM.SetActive(true);
            PlayerS.SetActive(false);
            Sm = false;
            Lm = false;
            Mm = true;
        }

        if (joystick.Vertical < -0.9)
        {
            PlayerL.SetActive(true);
            PlayerM.SetActive(false);
            PlayerS.SetActive(false);
            Sm = false;
            Lm = true;
            Mm = false;
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "sball" && Sm==true)
        {
            sayac+=5;
            Skor.text = "" + sayac;
        }
        if (collider.gameObject.tag == "mball" && Mm == true)
        { 
            sayac+=4;
            Skor.text = "" + sayac;
        }
        if (collider.gameObject.tag == "lball" && Lm == true)
        {
            sayac+=3;
            Skor.text = "" + sayac;
        }
        if (collider.gameObject.tag == "sball" && Sm == false)
        {
            sayac ++;
            Skor.text = "" + sayac;
        }
        if (collider.gameObject.tag == "mball" && Mm == false)
        {
            sayac ++;
            Skor.text = "" + sayac;
        }
        if (collider.gameObject.tag == "lball" && Lm == false)
        {
            sayac ++;
            Skor.text = "" + sayac;
        }
        if (collider.gameObject.tag == "bomb")
        {
            sayac+=2;
            Skor.text = "" + sayac;
        }

        if (sayac > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", sayac);
            highScore.text = sayac.ToString();
        }
    }
}
