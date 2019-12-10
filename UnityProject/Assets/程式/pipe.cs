//子類別 繼承 父類別
//可享有父類別的成員

public class pipe : floor
{
    //前提:需要有 Mesh Renderer 元件
    //在所有相機看不到時 呼叫一次
    private void OnBecameInvisible()
    {
        print("看不到");
        Destroy(gameObject, 2);     //摧毀(物件,延遲時間)   gameObject 指此物件
    
    }

    private void OnBecameVisible()
    {
        print("看到了");
    }
}
