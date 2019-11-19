
using UnityEngine;

public class floor : MonoBehaviour
{
    [Header("地板速度"),Range(1,100),Tooltip("控制地板的移動速度")]
    public float floorspeed=10f;//地板速度

    /// <summary>
    /// 地板移動功能
    /// </summary>
    private void Move()
    {
        
    }
}
