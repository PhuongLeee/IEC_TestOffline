using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOpenCheatMenu : MonoBehaviour
{
    private int checkL = 0;
    [SerializeField] RectTransform cheatPanel;
    public void CheckOpenCheatLeft() {
        if (checkL % 2==0) {            
            checkL++;
            if (checkL == 5) {
                cheatPanel.gameObject.SetActive(true);
            }
        } else checkL = 0;
    }
    public void CheckOpenCheatRight() {
        if (checkL % 2 != 0) checkL++;
        else checkL = 0;
    }
}
