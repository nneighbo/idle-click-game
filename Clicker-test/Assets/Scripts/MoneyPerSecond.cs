using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyPerSecond : MonoBehaviour
{
    public bool GeneratingCash = false;
    public static int CashFlow = 1;
    public int InternalCashFlow;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
     InternalCashFlow = CashFlow;
     if(GeneratingCash == false){
         GeneratingCash = true;
         StartCoroutine(CreateCash());
     } 
    }

    IEnumerator CreateCash () {
        GlobalMoney.Money += InternalCashFlow;
        yield return new WaitForSeconds(1);
        GeneratingCash = false;
    }
}
