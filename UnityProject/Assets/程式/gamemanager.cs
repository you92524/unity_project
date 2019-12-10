using UnityEngine.SceneManagement;  //引用 場景管理 API
using UnityEngine.UI;   //引用 介面 API
using UnityEngine;



public class gamemanager : MonoBehaviour
{
    [Header("目前分數")]
    public int now = 0;    //目前分數
    [Header("最高分數")]
    public int best = 0;   //最高分數
    [Header("水管")]
    public GameObject pipe;// GameObject :可以存放預製物
    [Header("介面群組")]
    public GameObject gmUI;
    [Header("分數群組")]
    public Text txt;
    [Header("最高分數群組")]
    public Text txtbest;

    public int add;

    /// <summary>
    /// 水管生成功能
    /// </summary>
    public void SpawnPipe()
    {
        //因為有繼承此類別才能簡寫
        //object.Instantiate(pipe);

        //浮點數 y = 隨機.靜態方法(最小,最大)
        float y = Random.Range(-2.19f, 2.75f);
        
        //三維向量 Vetor3 - x,y,z
        Vector3 pos = new Vector3(6f, y, 0);
        
        //四元數 Quaterion - x,y,z,w
        Quaternion rot = new Quaternion(0, 0, 0, 0);

        Instantiate(pipe,pos,rot);
    }

    /// <summary>
    /// 加分功能
    /// </summary>
    /// <param name="now">要添加的分數</param>
    public void AddScore(int add)
    {
        now = now+add;
        //txt.text = now + "";     //另一種轉字串的方法
        txt.text = now.ToString(); //整數.轉字串()

        SetHeightScore();
    }

    /// <summary>
    /// 設定最高分數
    /// </summary>
    private void SetHeightScore()
    {
        //取得 最高分數 於 裝置
        best = PlayerPrefs.GetInt("最佳得分");
        
        // 如果  目前分數 > 最高分數
        if (now > best)
        {
            //最高分數 = 目前分數
            best = now;
            PlayerPrefs.SetInt("最佳得分",best);
        }
        txtbest.text = best.ToString();
    }

    /// <summary>
    /// 遊戲結束
    /// </summary>
    public void GameOver()
    {
        gmUI.SetActive(true);
        floor.floorspeed = 0;
    }

    /// <summary>
    /// 重新遊戲
    /// </summary>
    public void Replay()
    {


        //  Application.LoadLevel("遊戲場景");      
        //應用程式.載入關卡("關卡名稱") 舊版 API

        SceneManager.LoadScene("遊戲場景");         
        //應用程式.載入場景("場景名稱") 新版 API

    }
    
    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void Exit()
    {
        Application.Quit();     //應用程式.離開遊戲
    }

    private void Start()
    {

        //SpawnPipe();
        InvokeRepeating("SpawnPipe", 1f, 2f);

        //取得 最高分數 於 裝置
        best = PlayerPrefs.GetInt("最佳得分");  //更新最高分數的介面
        txtbest.text = best.ToString();

        floor.floorspeed = 10f;
        
    }
}
