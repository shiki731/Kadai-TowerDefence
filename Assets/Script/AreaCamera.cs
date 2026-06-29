using UnityEngine;

public class AreaCamera : MonoBehaviour
{
    // プレイヤーにつけるスクリプト
    // キャラの位置に応じてカメラの位置をマップに応じて変える(AreaSystemのareaNum参照)

    private float CameraPosX;
    private float CameraPosY;

    void Update()
    {
        CameraPosX = Mathf.Clamp(transform.position.x, AreaSystem.camLeft + AreaSystem.AreaCenter.x, AreaSystem.camRight + AreaSystem.AreaCenter.x);
        CameraPosY = Mathf.Clamp(transform.position.y, AreaSystem.camDown + AreaSystem.AreaCenter.y, AreaSystem.camTop + AreaSystem.AreaCenter.y);

        Camera.main.transform.position = new Vector3(CameraPosX, CameraPosY, -10);

    }
}
