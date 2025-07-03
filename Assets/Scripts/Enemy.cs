using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] Gm manager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0,speed,0) * Time.deltaTime;
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Gm.instance.InitiateGameOver();
        }
        else{
       
            Gm.instance.IncreaseScore(10);

        }
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
