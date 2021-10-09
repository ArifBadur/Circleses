using UnityEngine;

public class InteractiveGamePlay : MonoBehaviour
{
    public GameObject popUp;
    public GameObject[] popUps;
    private int popUpIndex = 0;
    private int startIndex = 1;
    public float waitTime = 2f;
    void Start()
    {
        //loadDelete();
        PlayerPrefs.GetInt("popUpSave");

        if (PlayerPrefs.GetInt("popUpSave") == 1)
        {
            Destroy(popUp);
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startIndex++;
            popUpIndex++;
            if (popUpIndex == 1)
            {
                Debug.Log("popUpIndex 1'e girdi");
                popUps[0].SetActive(false);
            }
            if (popUpIndex == 2)
            {
                Debug.Log("popUpIndex 2'ye girdi");
                popUps[1].SetActive(false);

            }
            if (popUpIndex == 3)
            {
                Debug.Log("popUpIndex 3'e girdi");
                popUps[2].SetActive(false);
                PlayerPrefs.SetInt("popUpSave", 1);
            }
        }
        switch (startIndex)
        {
            case 1:
                Debug.Log("PopUp 0'a girdi");
                popUps[0].SetActive(true);
                break;
            case 2:
                Debug.Log("PopUp 1'a girdi");
                popUps[1].SetActive(true);
                break;
            case 3:
                Debug.Log("PopUp 2'a girdi");
                popUps[2].SetActive(true);
                break;
        }
    }
    private void loadDelete()
    {
        PlayerPrefs.DeleteKey("popUpSave");
    }
}