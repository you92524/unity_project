using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    private void Start()
    {
        print("輸出");

        Debug.Log("輸出訊息");

        //靜態成員:屬性的取得方式
        print(Random.value);

        //練習取得 PI
        print(Mathf.PI);

        // 靜態方法：類別.方法(對應的參數);
        print("隨機範圍:" + Random.Range( 10.5f,11.5f));

        //object 任何類型:int, float,string,bool
        Debug.LogError("出錯啦");
        Debug.LogWarning("在改剁手");
    }

    private void Update()
    {
        //打印出   輸入的按鍵   的字串
        print(Input.inputString);

        //練習:請練習偵測玩家有沒有按S
        print("按下S鍵:"+Input.GetKeyDown("s"));
    }
}
