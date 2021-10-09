using System.Collections;
using UnityEngine;

public class RandomEnemySpawn : MonoBehaviour
{
    public GameObject[] balls;
    public int lane;

    void Start()
    {
        StartCoroutine(GKF());
    }

    IEnumerator GK()
    {
        var b = Random.Range(0, 4);
        yield return new WaitForSeconds(0.1f);
        lane = Random.Range(1, 8);
      
        switch (lane)
        {

            case 1:
                Vector3 posXY = new Vector3(3, 3, 0);
                GameObject yeni_sballXY = Instantiate(balls[b], posXY, Quaternion.Euler(0, 0, 135));
                break;

            case 2:
                Vector3 posxY = new Vector3(-3, 3, 0);
                GameObject yeni_sballxY = Instantiate(balls[b], posxY, Quaternion.Euler(0, 0, -135));
                break;

            case 3:
                Vector3 posxy = new Vector3(-3, -3, 0);
                GameObject yeni_sballxy = Instantiate(balls[b], posxy, Quaternion.Euler(0, 0, -45));
                break;

            case 4:
                Vector3 posXy = new Vector3(3, -3, 0);
                GameObject yeni_sballXy = Instantiate(balls[b], posXy, Quaternion.Euler(0, 0, 45));
                break;

            case 5:
                Vector3 posX = new Vector3(4.2f, 0, 0);
                GameObject yeni_sballX = Instantiate(balls[b], posX, Quaternion.Euler(0, 0, 90));
                break;

            case 6:
                Vector3 posx = new Vector3(-4.2f, 0, 0);
                GameObject yeni_sballx = Instantiate(balls[b], posx, Quaternion.Euler(0, 0, -90));
                break;

            case 7:
                Vector3 posY = new Vector3(0, 4.2f, 0);
                GameObject yeni_sballY = Instantiate(balls[b], posY, Quaternion.Euler(0, 0, 180));
                break;
        }
    }
    IEnumerator GKF()
    {
        for (int i = 0; i < 10000; i++)
        {
            if (i <= 10)
            {
                StartCoroutine(GK());
                yield return new WaitForSeconds(6f);
            }
            
            if(i > 10)
            {
                StartCoroutine(GK());
                yield return new WaitForSeconds(5f);
            }
            if (i> 25)
            {
                StartCoroutine(GK());
                yield return new WaitForSeconds(4f);
            }
            if (i > 50)
            {
                StartCoroutine(GK());
                yield return new WaitForSeconds(3f);
            }
            if (i > 100)
            {
                StartCoroutine(GK());
                yield return new WaitForSeconds(2f);
            }


        }
    }
}
