using System.Collections;
using UnityEngine;

public class EnemySporn : MonoBehaviour
{
    public GameObject[] enemy;
    private bool spawnCheck;
    void Start()
    {
        spawnCheck = true;
    }

    void Update()
    {
        if (spawnCheck)
        {
            StartCoroutine(Spowm());
        }
    }

    IEnumerator Spowm()
    {
        spawnCheck = false;
        yield return new WaitForSeconds(1);
        Debug.Log("aaaa");
        spawnCheck = true;
    }
}
