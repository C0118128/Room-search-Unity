using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBackManager : MonoBehaviour
{
    //panelの取得
    public GameObject ThisPanel;

    //TriggerBottonとの連結
    public void OnClickTurnBackTrigger()
    {
        ThisPanel.SetActive(false);
    }
}
