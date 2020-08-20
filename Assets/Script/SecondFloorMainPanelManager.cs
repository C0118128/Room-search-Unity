using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondFloorMainPanelManager : MonoBehaviour
{
    //panelの取得
    public GameObject SecondFloorMainBoxPanel;
    public GameObject SecondFloorMainBedPanel;
    public GameObject SecondFloorMainLeftPanel;

    public GameObject SecondFloorRightPanel;


    //TriggerBottonとの連結
    public void OnClickSecondFloorMainBoxTrigger()
    {
        SecondFloorMainBoxPanel.SetActive(true);
    }
    public void OnClickSecondFloorMainBedTrigger()
    {
        SecondFloorMainBedPanel.SetActive(true);
    }
    public void OnClickSecondFloorMainLeftTrigger()
    {
        SecondFloorMainLeftPanel.SetActive(true);
    }

    public void OnClickRightTrigger()
    {
        SecondFloorRightPanel.SetActive(true);
    }
}
