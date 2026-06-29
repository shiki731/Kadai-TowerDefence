using TMPro;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public static int score;
    public TextMeshProUGUI tmp;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = score.ToString();
    }

    public void ScoreDown(int minus)
    {
        score -= minus;
    }
}
