using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstFloorLeftManager : MonoBehaviour
{
    //panelの取得

    public GameObject FirstFloorLeftBoxPanel;

    public GameObject ThisPanel;
    public GameObject FirstFloorBackPanel;

    //TriggerBottonとの連結
    public void OnClickFirstFloorLeftBoxTrigger()
    {
        FirstFloorLeftBoxPanel.SetActive(true);
    }

    public void OnClickRightTrigger()
    {
        ThisPanel.SetActive(false);
    }
    public void OnClickLeftTrigger()
    {
        FirstFloorBackPanel.SetActive(true);
        ThisPanel.SetActive(false);
    }

}
