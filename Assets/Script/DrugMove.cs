using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class DrugMove : MonoBehaviour
{
    //カメラフォロワーにつけるスクリプト

    private Vector2 mousePos;
    private Vector2 followerPos;

    private float nowFollowerPosX;
    private float nowFollowerPosY;

    private bool clickCheck;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            mousePos = Mouse.current.position.ReadValue();
            Debug.Log("PosX = " + mousePos.x + ",PosY = " + mousePos.y);
            clickCheck = true;
        }
        if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            clickCheck = false;
        }

        if (clickCheck)
        {
            Vector2 nowMousePos = Mouse.current.position.ReadValue();
            float followerPosX = (mousePos.x - nowMousePos.x) / 100;
            float followerPosY = (mousePos.y - nowMousePos.y) / 100;
            //Vector2 followerPos = new Vector2(followerPosX, followerPosY);

            nowFollowerPosX = followerPosX;
            nowFollowerPosY = followerPosY;
            
        }
        transform.position = new Vector2(nowFollowerPosX, nowFollowerPosY);

    }
}
