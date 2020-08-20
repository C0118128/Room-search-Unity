using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstFloorRightManager : MonoBehaviour
{
    //panelの取得

    public GameObject FirstFloorRightKeyBoxPanel;

    public GameObject ThisPanel;
    public GameObject FirstFloorBackPanel;

    //TriggerBottonとの連結
    public void OnClickFirstFloorRightKeyBoxTrigger()
    {
        FirstFloorRightKeyBoxPanel.SetActive(true);
    }

    public void OnClickRightTrigger()
    {
        FirstFloorBackPanel.SetActive(true);
        ThisPanel.SetActive(false);
    }
    public void OnClickLeftTrigger()
    {
        ThisPanel.SetActive(false);
    }

}
