﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunBusiness : MonoBehaviour
{
      Transform button;
        public static int CostDisplay;
        public static int AmountDisplay;
        public static int PromotePay;

        public  int InternalCostDisplay;
        public  int InternalAmountDisplay;
        public  int InternalPromotePay;

        string newCost;
        string newAmount;
        string newPay;

    void Format(int cost, int amount, int pay) {
        newCost = cost.ToString("C0");
        newAmount = amount.ToString("N0");
        newPay = pay.ToString("C0");
        return;
    }

    void Start()
    {
        if(OpenUpgrades.ToggleMenu == true){
        if(CostDisplay > 0){
            InternalCostDisplay = CostDisplay;
        }
        if(AmountDisplay > 0){
        InternalAmountDisplay = AmountDisplay;
        }
        if(PromotePay > 0){
        InternalPromotePay = PromotePay;
        }
        button = GameObject.Find("RunBusiness").transform;
        Format(InternalCostDisplay,InternalAmountDisplay,InternalPromotePay);
        button.GetChild(1).GetComponent<Text>().text = "Cost: " + newCost;
        button.GetChild(2).GetComponent<Text>().text = "Amount: " + newAmount;
        button.GetChild(4).GetComponent<Text>().text = newPay;
        }
    }

    void Update()
    {
        if(OpenUpgrades.ToggleMenu == true){
        if(CostDisplay > 0){
            InternalCostDisplay = CostDisplay;
        }
        if(AmountDisplay > 0){
        InternalAmountDisplay = AmountDisplay;
        }
        if(PromotePay > 0){
        InternalPromotePay = PromotePay;
        }
        button = GameObject.Find("RunBusiness").transform;
        Format(InternalCostDisplay,InternalAmountDisplay,InternalPromotePay);
        button.GetChild(1).GetComponent<Text>().text = "Cost: " + newCost;
        button.GetChild(2).GetComponent<Text>().text = "Amount: " + newAmount;
        button.GetChild(4).GetComponent<Text>().text = newPay;
        }
    }
    
    public void PromoteClick () {
        InternalCostDisplay = CostDisplay;
        InternalAmountDisplay = AmountDisplay;
        InternalPromotePay = PromotePay;
        Format(InternalCostDisplay,InternalAmountDisplay,InternalPromotePay);
          if(InternalCostDisplay <= 10000){
            InternalCostDisplay = 10000;
        } 
        button = GameObject.Find("RunBusiness").transform;
        button.GetChild(1).GetComponent<Text>().text = "Cost: " + newCost;
        button.GetChild(2).GetComponent<Text>().text = "Amount: " + newAmount;
        button.GetChild(4).GetComponent<Text>().text = newPay;
                var output = JsonUtility.ToJson(InternalCostDisplay, true);
                var output2 = JsonUtility.ToJson(InternalAmountDisplay, true);
                var output3 = JsonUtility.ToJson(InternalPromotePay, true);

               if(GlobalMoney.Money >= InternalCostDisplay){
            if(InternalAmountDisplay == 0){
                MoneyPerSecond.CashFlow += 25;
                InternalPromotePay += 25;
            } else {
                MoneyPerSecond.CashFlow += 25 * InternalAmountDisplay;
                InternalPromotePay += (25 * InternalAmountDisplay);
            }
           GlobalMoney.Money -= InternalCostDisplay;
           InternalAmountDisplay  = InternalAmountDisplay + 1;
           InternalCostDisplay = 10000 * (InternalAmountDisplay + 1);
        Format(InternalCostDisplay,InternalAmountDisplay,InternalPromotePay);
        button.GetChild(1).GetComponent<Text>().text = "Cost: " + newCost;
        button.GetChild(2).GetComponent<Text>().text = "Amount: " + newAmount;
        button.GetChild(4).GetComponent<Text>().text = newPay;
        CostDisplay = InternalCostDisplay;
        AmountDisplay = InternalAmountDisplay;
        PromotePay = InternalPromotePay;
        }
    }
}
