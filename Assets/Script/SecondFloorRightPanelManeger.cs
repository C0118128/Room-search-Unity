using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondFloorRightPanelManeger : MonoBehaviour
{
    //panelの取得
    public GameObject SecondFloorMainPanel;

    public GameObject ThisPanel;


    //TriggerBottonとの連結
    public void OnClickLeftTrigger()
    {
        ThisPanel.SetActive(false);
    }

    public void OnClickFirstFloorMainTrigger()
    {
        SecondFloorMainPanel.SetActive(false);
        ThisPanel.SetActive(false);
    }
}
