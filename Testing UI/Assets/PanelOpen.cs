using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpen : MonoBehaviour
{

    public GameObject riddleOne;
    bool active;

    public void PanelStatus() {
        if (active == false) {
            riddleOne.SetActive(true);
            active = true;
        }
        else {
            riddleOne.SetActive(false);
            active = false;
        }
       // riddleOne.SetActive(true);
    }
}
