using UnityEngine;
//using UnityEngine.SceneManagement;

public class EnemyMove : MonoBehaviour
{
    private float speed = 2.0f;
    public GameSystem system;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            system.ScoreUp();
            Destroy(gameObject);
        }
    }
}
