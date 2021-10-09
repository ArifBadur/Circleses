using UnityEngine;
using UnityEngine.SceneManagement;

public class menuS : MonoBehaviour
{
    public GameObject GameScreen, PauseScreen, Dropd, SettingsOn, SettingsOff, SoundsOn, SoundsOff, MusicOn, MusicOff, HowToOn, HowToOff, Droph;

    void AdsButton()
    {

    }

    public void RestartButton()
    {
        SceneManager.LoadScene(0);
    }

    public void HowToOnButton()
    {
        Droph.SetActive(true);
        HowToOn.SetActive(false);
        HowToOff.SetActive(true);
    }

    public void HowToOffButton()
    {
        Droph.SetActive(false);
        HowToOn.SetActive(true);
        HowToOff.SetActive(false);
    }

    public void StarButton()
    {
        Application.OpenURL("https://play.google.com");
    }

    public void SettingsOnButton()
    {
        Dropd.SetActive(true);
        SettingsOn.SetActive(false);
        SettingsOff.SetActive(true);

    }
    public void SettingsOffButton()
    {
        Dropd.SetActive(false);
        SettingsOff.SetActive(false);
        SettingsOn.SetActive(true);
    }

    public void pauseBButton()
    {
        PauseScreen.SetActive(false);
        GameScreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void pauseBBButton()
    {
        PauseScreen.SetActive(true);
        GameScreen.SetActive(false);
        Time.timeScale = 1;
    }

    public void SoundsOnButton()
    {
        SoundsOn.SetActive(false);
        SoundsOff.SetActive(true);
    }
    public void SoundsOffButton()
    {
        SoundsOn.SetActive(true);
        SoundsOff.SetActive(false);
    }
    public void MusicOnButton()
    {
        MusicOn.SetActive(false);
        MusicOff.SetActive(true);
    }
    public void MusicOffButton()
    {
        MusicOn.SetActive(true);
        MusicOff.SetActive(false);
    }
}
