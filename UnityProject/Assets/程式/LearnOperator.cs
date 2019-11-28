
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

        //邏輯運算子
        //結果是布林值
        // 並聯(and)  &&
        //規則:只要有一個 false 就會傳回 false

        print(true && true  );      //true
        print(true && false );      //false
        print(false && true );      //false
        print(false && false);      //false


        //邏輯運算子
        //結果是布林值
        // 串聯(or)  ||
        //規則:只要有一個 true 就會傳回 true

        print(true  || true);       //true
        print(true  || false);      //true
        print(false || true);       //true
        print(false || false);      //false

        //邏輯運算子
        //結果是布林值
        // 相反(not)  !
        //規則:將布林值變相反

        print(!false);  //true
        print(!true);   //false



    }
}
