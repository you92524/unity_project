using UnityEngine;

public class littlechicken : MonoBehaviour
{
    [Header("跳越高度"),Range(100,1000)]
    [Tooltip("控制小雞的跳越高度，數值越大，越高")]
    public int jumphihnt=5;    //跳躍高度

    [Header("生存狀態"),Tooltip("小雞的生存狀態，打勾:存活，取消:死亡")]
    public bool surive = true; //生存狀態 預設 活著

    public GameObject goscore, goGM;

    [Header("剛體")]
    public Rigidbody2D r2d;

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

            r2d.gravityScale = 1f;  // 剛體 重力=1

            r2d.Sleep();            //剛體 睡覺

            r2d.AddForce(new Vector2(0f,jumphihnt));    //剛體 增加推力(二維向量)

        }
        //剛體.加速度velocity     (x,y)  x:左右    y:上下
        r2d.SetRotation(4.95f*r2d.velocity.y);         //剛體.設定旋轉(浮點數_角度)

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
