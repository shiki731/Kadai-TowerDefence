using TMPro;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    public static int score;
    public int damage = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreUp()
    {
        score -= damage;
    }
}
