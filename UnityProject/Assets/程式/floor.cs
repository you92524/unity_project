
using UnityEngine;

public class floor : MonoBehaviour
{
    //static    靜態  隱藏
    //  此類別共用  包含子類別
    //[Header("地板速度"), Range(1, 100), Tooltip("控制地板的移動速度")]
    public static float floorspeed = 10f;//地板速度

    [Header("變形"), Tooltip("需要移動的項目")]
    public Transform fm;

    /// <summary>
    /// 地板移動功能
    /// </summary>
    private void Move()
    {
        //Time.deltaTime 一幀的時間
        fm.Translate(-floorspeed * Time.deltaTime, 0, 0);
    }

    private void Update()
    {
        Move();
    }
}
