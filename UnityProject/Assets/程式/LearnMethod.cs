using UnityEngine;

public class LearnMethod : MonoBehaviour
{
   // 定義方法 Method (宣告函式,功能)
   //語法:
   //修飾詞 方法傳回類型 方法名稱() { }
   //void:無傳回

   /// <summary>
   /// 開頭的廣播，使玩家知道現在狀況
   /// </summary>
   private void Text()
    {
        print("廣播:今天天氣晴，但是會下糖果");
    }

    private void Start()
    {
        //呼叫方法
        Text();
        Text();
    }
}
