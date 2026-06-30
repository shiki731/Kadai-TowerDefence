using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    // プレイヤーにつけるスクリプト
    // キャラの位置に応じてカメラの位置をマップに応じて変える(AreaSystemのareaNum参照)

    private float CameraPosX;
    private float CameraPosY;

    void Update()
    {
        CameraPosX = Mathf.Clamp(transform.position.x, CameraMoveRange.camLeft + CameraMoveRange.AreaCenter.x, CameraMoveRange.camRight + CameraMoveRange.AreaCenter.x);
        CameraPosY = Mathf.Clamp(transform.position.y, CameraMoveRange.camDown + CameraMoveRange.AreaCenter.y, CameraMoveRange.camTop + CameraMoveRange.AreaCenter.y);

        Camera.main.transform.position = new Vector3(CameraPosX, CameraPosY, -10);

    }
}
