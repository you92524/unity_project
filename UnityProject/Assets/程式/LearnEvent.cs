using UnityEngine;

public class LearnEvent : MonoBehaviour
{
    //事件:在特定時間以指定次數執行
    //開始事件:在播放後執行一次
    //語法:
    //修飾詞 傳回類型 名稱() {}
    private void Start()
    {
        //輸出方法(物件)
        print("開始-1");
    }
    //更新事件:每幀執行1次[每秒執行約 60 次 ( 60FPS  frame per second)]
    private void Update()
    {
     
        print("嘿嘿嘿~~");
     
    }
}
