using UnityEngine;

public class littlechicken : MonoBehaviour
{
    [Header("跳越高度"),Range(1,100)]
    [Tooltip("控制小雞的跳越高度，數值越大，越高")]
    public int jumphihnt=5;    //跳躍高度

    [Header("生存狀態"),Tooltip("小雞的生存狀態，打勾:存活，取消:死亡")]
    public bool surive = true; //生存狀態 預設 活著

    public GameObject goscore, goGM;

    /// <summary>
    /// 小雞跳躍功能
    /// </summary>
    private void Jump()
    {
        //如果 按下 左鍵
        if (Input.GetKeyDown(KeyCode.Mouse0 ))
        {
            print("按下左鍵");

            // 顯示/啟動 分數
            goscore.SetActive(true);
            // 顯示/起動 遊戲管理員
            goGM.SetActive(true);
        }
    }

    /// <summary>
    /// 小雞存活功能
    /// </summary>
    private void Dead()
    {

    }

    /// <summary>
    /// 小雞通過水管
    /// </summary>
    private void PassPipe()
    {

    }

    //監聽玩家輸入:鍵盤、滑鼠、搖桿
    private void Update()
    {
        Jump();   
    }
}
