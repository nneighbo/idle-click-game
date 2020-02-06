using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenUpgrades : MonoBehaviour
{
    public GameObject UpgradesMenu;
    public static bool ToggleMenu;

   public void Update () {
        if(UpgradesMenu.activeSelf == true){
            ToggleMenu = true;
        } else {
            ToggleMenu = false;
        }
    }

    public void OpenUpgradePanel () {
        if(UpgradesMenu.activeSelf == true){
            UpgradesMenu.SetActive(false);
            ToggleMenu = false;
        } else {
            UpgradesMenu.SetActive(true);
            ToggleMenu = true;
        }
    }
}
