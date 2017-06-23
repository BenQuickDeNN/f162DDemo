using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnGUI()
    {
        const int buttonWidth = 84;
        const int buttonHeight = 60;

        // 在开始游戏界面绘制一个按钮
        if (
          // Center in X, 2/3 of the height in Y
          GUI.Button(new Rect(Screen.width / 2 - (buttonWidth / 2), (2 * Screen.height / 3) - (buttonHeight / 2), buttonWidth, buttonHeight), "开始游戏")
        )
        {
            // On Click, load the first level.
            // "Stage1" is the name of the first scene we created.
            Application.LoadLevel("scenes1");
        }
        if (
          // Center in X, 2/3 of the height in Y
          GUI.Button(new Rect(Screen.width / 2 - (buttonWidth / 2), (2 * Screen.height / 3) + (buttonHeight / 2) + 10, buttonWidth, buttonHeight), "退出游戏")
        )
        {
            Application.Quit();
        }
    }
}
