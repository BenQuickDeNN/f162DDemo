using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHUD : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnGUI()
    {
        const int buttonWidth = 80;
        const int buttonHeight = 40;

        // 在开始游戏界面绘制一个按钮
        if (
          // Center in X, 2/3 of the height in Y
          GUI.Button(new Rect(20, 20, buttonWidth, buttonHeight), "返回主菜单")
        )
        {
            // On Click, load the first level.
            // "Stage1" is the name of the first scene we created.
            Application.LoadLevel("menuScenes");
        }
        GUI.Label(new Rect(20 + buttonWidth + 20, 20, buttonWidth * 4, buttonHeight), "使用\"WSAD\"或方向键控制方向，Ctrl键开火");
    }
}
