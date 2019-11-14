using UnityEngine;// 呼叫Unity API 資料庫
//類別 類別名稱
public class first : MonoBehaviour
{
    //定義欄位  field   (宣告變數) 
    //語法:
    //修飾詞   欄位類別  欄位名稱(指定 值)    結束
    //修飾詞:
    //      私人    pravate -隱藏(預設)
    //      公開    public  -公開

    public int lv = 1;                  //整數(預設 0)
    public float speed = 10f;           //浮點數(有小數點的數) (預設 0.0)
    public string item = "生命藥水";    //字串(預設" ")
    public bool mission = true;         //布林值(一件事的判定 true or false ) (預設 false)

    //屬性
    //語法:
    //[標題(header)   (標題內容("字串"))]
    [Header("力量")]
    public int STR = 1;
    [Header("敏捷")]
    public int VIT = 1;

    //[提示("提示內容")]
    [Header(("死亡"))]
    [Tooltip("用來紀錄玩家是否死亡，打勾:死亡，取消:沒死")]
    public bool dead;

    //[範圍(最小值,最大值)
    [Header("魔力"), Range(0, 999)]
    public int MP = 10;
}
