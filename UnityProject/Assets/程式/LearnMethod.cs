using UnityEngine;

public class LearnMethod : MonoBehaviour
{
   // 定義方法 Method (宣告函式,功能)
   //語法:
   //修飾詞 方法傳回類型 方法名稱() { }
   //參數語法:參數類型 參數名稱
   //void:無傳回

   /// <summary>
   /// 開頭的廣播，使玩家知道現在狀況
   /// </summary>
   /// <pargam name="speed">車子速度</pargam>
   private void Text()
    {
        print("廣播:今天天氣晴，但是會下糖果");
    }
   
    /// <summary>
    /// 開車
    /// </summary>
    /// <pargam name="speed">車子速度</pargam>
    private void drive(int speed)
    {
        print("引擎音效");
        //字串可以使用"+"號與其他形態串接，結果為字串
        print("車子正在往前開，時速:" + speed);
    }
    //多重參數使用"，"逗號隔開
    //參數不能重複名稱，可以與欄位相同
    //參數可以給預設值，選填式參數
    //選填式參數只能寫在最後面
    private void shoot(int count, string direction = "前方",string prop="無屬性")
    {
        print("弓箭數量:" + count);
        print("弓箭方向:" + direction);
        print("弓箭屬性:" + prop);
    }
    
    //有傳回
    private string PrintName(string name)
    {
        return "嗨~" + name + "你好~";
    }

    private void Start()
    {
        //呼叫方法，給予對應的引數
        Text();
        Text();
        drive(99);
        drive(999);
        //不填寫選填式參數，以預設值值行方法
        shoot(1);
        shoot(10, "前後");
        //可以具名使用指定的選填式參數
        shoot(10, prop: "火屬性");

        //區域欄位，不需要修飾詞
        string pn = PrintName("KID");
        print(pn);
        //將傳回方法當作傳回類型資料使用
        print(PrintName("拔剌~"));
    }
}
