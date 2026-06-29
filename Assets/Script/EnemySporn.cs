using System.Collections;
using UnityEngine;

public class EnemySporn : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Spowm());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spowm()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("aaaa");
    }
}
