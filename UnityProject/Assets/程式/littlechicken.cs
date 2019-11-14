using UnityEngine;

public class littlechicken : MonoBehaviour
{
    [Header("跳越高度"),Range(1,100)]
    [Tooltip("控制小雞的跳越高度，數值越大，越高")]
    public int jumphihnt=5;    //跳躍高度

    [Header("生存狀態"),Tooltip("小雞的生存狀態，打勾:存活，取消:死亡")]
    public bool surive = true; //生存狀態 預設 活著

    /// <summary>
    /// 小雞跳躍
    /// </summary>
    private void jump()
    {

    }
}
