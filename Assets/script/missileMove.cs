using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileMove : MonoBehaviour {
    #region 1 - 变量

    /// <summary>
    /// 物体移动速度
    /// </summary>
    public Vector2 speed = new Vector2(10, 10);

    /// <summary>
    /// 移动方向
    /// </summary>
    public Vector2 direction = new Vector2(-1, 0);

    private Vector2 movement;

    #endregion
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // 2 - 保存运动轨迹
        movement = new Vector2(speed.x * direction.x, speed.y * direction.y);
    }
    void FixedUpdate()
    {
        var missileObj = GetComponent<Rigidbody2D>();
        //让游戏物体移动
        missileObj.velocity = movement;
    }
}
