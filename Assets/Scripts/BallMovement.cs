using UnityEngine;

public class BallMovement : MonoBehaviour
{
  
    public float Speed;
    Rigidbody rigid;
   
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rigid.velocity = (transform.up * Time.deltaTime * Speed);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (collider.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
        }
    }
}

