using UnityEngine;

public class littlechicken : MonoBehaviour
{
    [Header("跳越高度"),Range(100,1000)]
    [Tooltip("控制小雞的跳越高度，數值越大，越高")]
    public int jumphihnt=550;    //跳躍高度

    [Header("生存狀態"),Tooltip("小雞的生存狀態，打勾:存活，取消:死亡")]
    public bool surive = true; //生存狀態 預設 活著

    public GameObject goscore, goGM;

    [Header("剛體")]
    public Rigidbody2D r2d;

    [Header("遊戲管理器")]
    public gamemanager gm;

    [Header("音效區域")]

    public AudioSource aud;
    [Header("跳躍音效,撞擊音效,加分音效")]
    public AudioClip sondjump, sondhit, sondaddpoint;

    /// <summary>
    /// 小雞跳躍功能
    /// </summary>
    private void Jump()
    {
        if (!surive)
        {
            return;         //跳出此方法
        }
        //如果 按下 左鍵
        if (Input.GetKeyDown(KeyCode.Mouse0 ))
        {
            print("按下左鍵");

            //音源.播放一次(音效片段，音量(浮點數))
            aud.PlayOneShot(sondjump,1f);   //音效API  使跳躍有音效
            
            // 顯示/啟動 分數
            goscore.SetActive(true);
            // 顯示/起動 遊戲管理員
            goGM.SetActive(true);

            r2d.gravityScale = 2f;  // 剛體 重力=1

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
        if (!surive)
        {
            return;         //跳出此方法     >>避免死亡後碰到水管還會有音效
        }
        surive = false;
        gm.GameOver();
        aud.PlayOneShot(sondhit, 1f);

    }

    /// <summary>
    /// 小雞通過水管
    /// </summary>
    private void PassPipe()
    {
        if (!surive)
        {
            return;         //跳出此方法     >>避免死亡後會加分的BUG
        }
        print("加分");
        gm.AddScore(1);
        aud.PlayOneShot(sondaddpoint, 1f);
    }

    //監聽玩家輸入:鍵盤、滑鼠、搖桿
    private void Update()
    {
        Jump();   
    }

    //碰撞事件:碰到其他碰撞器開始執行一次(碰到物件的碰撞資訊)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);
        Dead();
    }

    //觸發事件:觸發其他碰撞器開始執行一次(針對勾選 IsTrigger 的物件)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.name == "04_水管" || collision.gameObject.name == "04_水管 (1)")
        {
            Dead();
        }
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "加分區域")
        {
            PassPipe();
        }
    }


}
