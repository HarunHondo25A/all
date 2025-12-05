using UnityEngine;

public class playerManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float moveSpeed = 0.1f;
    [SerializeField] float life = 5f;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(moveSpeed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0f, moveSpeed * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0f, -moveSpeed * Time.deltaTime, 0f);
        }
        {
            
        }

        if (life <= 0f)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            life -= 1f;
        }
    }
}