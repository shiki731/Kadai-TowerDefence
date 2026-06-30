using UnityEngine;
//using UnityEngine.SceneManagement;

public class EnemyMove : MonoBehaviour
{
    private float speed = 1.0f;
    public GameSystem system;
    public Transform playerPos;
    public int damage = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        float angle = GetAngle(transform.position,playerPos.position);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    float GetAngle(Vector2 fromP,Vector2 toP)
    {
        float dx = toP.x - fromP.x;
        float dy = toP.y - fromP.y;
        float rad = Mathf.Atan2(dy, dx);
        return rad * Mathf.Rad2Deg;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            system.ScoreDown(damage);
            Destroy(gameObject);
        }
    }
}
