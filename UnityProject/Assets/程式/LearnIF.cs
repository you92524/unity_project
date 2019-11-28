using UnityEngine;

public class LearnIF : MonoBehaviour
{
    public bool open;
    public int score;
    public int combo;

    // 判斷式 if(switch)
    // 語法:
    //  if(布林值) {當 if() 布林值為 true 執行這裡 }
    private void Start()
    {
        if (true)
        {
            print("FUCK");
        }
    }

    private void Update()
    {
        //  if(布林值) {當 if() 布林值為 true 執行這裡 }
        if (open)
        {
            print("開門!");
        }
        //  else {當 if() 布林值為 false 執行這裡 }
        else
        {
            print("關門!");
        }


        if (score >= 60)
        {
            print("你及格了!");
        }
        else if (score >= 50)
        {
            print("你可以補考了!");
        }
        else if (score >= 40)
        {
            print("你可以花錢補考了!");
        }
        else
        {
            print("你可以重修了!");
        }

        // combo 次數 要由大排到小
        // 程式由上往下執行
        // 不然會先遇到 可以的條件 然後跳出判斷程式
        if (combo >= 150)
        {
            print("攻擊10倍");
        }
        else if(combo >= 100)
        {
            print("攻擊5倍");
        }
        else if (combo >= 50)
        {
            print("攻擊2倍");
        }
        else
        {
            print("攻擊正常");
        }
    }

}
