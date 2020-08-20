using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstFloorMainPanelManager : MonoBehaviour
{
    //panelの取得
    public GameObject FirstFloorMainTablePanel;
    public GameObject FirstFloorMainBoxPanel;

    public GameObject FirstFloorRightPanel;
    public GameObject FirstFloorLeftPanel;
    public GameObject FirstFloorBackPanel;

    public GameObject SecondFloorMainPanel;


    //TriggerBottonとの連結
    public void OnClickFirstFloorMainTableTrigger()
    {
        FirstFloorMainTablePanel.SetActive(true);
    }
    public void OnClickFirstFloorMainBoxTrigger()
    {
        FirstFloorMainBoxPanel.SetActive(true);
    }

    public void OnClickRightTrigger()
    {
        FirstFloorRightPanel.SetActive(true);
    }
    public void OnClickLeftTrigger()
    {
        FirstFloorLeftPanel.SetActive(true);
    }
    public void OnClickDwonTrigger()
    {
        FirstFloorBackPanel.SetActive(true);
    }

    public void OnClickSecondFloorMainTrigger()
    {
        SecondFloorMainPanel.SetActive(true);
    }
}
