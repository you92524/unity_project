
using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    private int a = 10, b = 3 ;
    private int c = 10, d = 3;

    private void Start()
    {
        // 數學運算子
        // + - * / %
        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b);

        a = a + 1;      //等號右邊先執行再存回左邊
        print(a++);     //先輸出在執行遞增
        print(++a);     //先執行遞增在輸出

        b = b  + 10;
        b += 10;        //適用 + - * / %

        //比較運算子
        //結果是布林值
        print(c > d);      // true
        print(c < d);      // false
        print(c >= d);     // true
        print(c <= d);     // false
        print(c == d);     // false
        print(c != d);     // true
    }
}
