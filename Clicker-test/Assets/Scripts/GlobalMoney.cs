using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMoney : MonoBehaviour
{
    public static int Money;
    public GameObject MoneyDisplay;
    public GameObject PayDisplay;
    public int InternalMoney;
    public static int Pay;
    public int InternalPay;
    public GameObject MoneyPerDisplay;

    void Start()
    {
        InternalMoney = Money;
        InternalPay = Pay;
        string newMoney = InternalMoney.ToString("C0");
        string newPay = InternalPay.ToString("C0");
        var cash = MoneyPerSecond.CashFlow;
        string newCash = cash.ToString("C0");

        MoneyDisplay.GetComponent<Text>().text = "Money: " + newMoney;
        PayDisplay.GetComponent<Text>().text = "Pay: " + newPay + "/per click";
        MoneyPerDisplay.GetComponent<Text>().text = newCash + "/per sec";
    }
    // Update is called once per frame
    void Update()
    {
        InternalMoney = Money;
        InternalPay = Pay;
        string newMoney = InternalMoney.ToString("C0");
        string newPay = InternalPay.ToString("C0");
        var cash = MoneyPerSecond.CashFlow;
        string newCash = cash.ToString("C0");

        MoneyDisplay.GetComponent<Text>().text = "Money: " + newMoney;
        PayDisplay.GetComponent<Text>().text = "Pay: " + newPay + "/per click";
        MoneyPerDisplay.GetComponent<Text>().text = newCash + "/per sec";
    }
}
