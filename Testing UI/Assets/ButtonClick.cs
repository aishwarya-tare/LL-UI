using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public Button enterButton;
    // Start is called before the first frame update
    void Start()
    {
        Button but = enterButton.GetComponent<Button>();
        but.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick() {
        //close the riddle and open the new one if correct answer
    }
}
