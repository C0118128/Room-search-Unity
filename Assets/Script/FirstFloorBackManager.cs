using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstFloorBackManager : MonoBehaviour
{
    //panelの取得
    public GameObject FirstFloorBackDoorPanel;

    public GameObject ThisPanel;
    public GameObject FirstFloorLeftPanel;
    public GameObject FirstFloorRightPanel;


    //TriggerBottonとの連結
    public void OnClickFirstFloorBackDoorTrigger()
    {
        FirstFloorBackDoorPanel.SetActive(true);
    }

    public void OnClickRightTrigger()
    {
        FirstFloorLeftPanel.SetActive(true);
        ThisPanel.SetActive(false);
    }
    public void OnClickLeftTrigger()
    {
        FirstFloorRightPanel.SetActive(true);
        ThisPanel.SetActive(false);
    }
    public void OnClickDownTrigger()
    {
        ThisPanel.SetActive(false);
    }

}
