using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ReadInput : MonoBehaviour {
    private string input;
    public string child;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void readString(string input) {
        this.input = input;
        Debug.Log(input);
    }
}