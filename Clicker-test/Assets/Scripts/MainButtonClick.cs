using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour {

    void Start () {
        if(GlobalMoney.Pay == 0){
           GlobalMoney.Pay = 1;
        }
        GlobalMoney.Money += GlobalMoney.Pay;
    }

    public void ClickTheButton () {
        if(GlobalMoney.Pay == 0){
           GlobalMoney.Pay = 1;
        }
        GlobalMoney.Money += GlobalMoney.Pay;
    }
}
