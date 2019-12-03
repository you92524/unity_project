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
    public void AddScore(int now)
    {

    }

    /// <summary>
    /// 設定最高分數
    /// </summary>
    private void SetHeightScore()
    {

    }

    /// <summary>
    /// 遊戲結束
    /// </summary>
    public void GameOver()
    {
        gmUI.SetActive(true);
    }

    private void Start()
    {

        //SpawnPipe();
        InvokeRepeating("SpawnPipe", 0, 2f);
    }
}
