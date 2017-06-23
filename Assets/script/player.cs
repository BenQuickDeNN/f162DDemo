using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    #region global var
    Vector2 PlayerSpeed = new Vector2(50, 50);
    Vector2 PlayerMovement;
    #endregion
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        PlayerMovement = new Vector2(PlayerSpeed.x * inputX, PlayerSpeed.y * inputY);
        #region 确保没有超出摄像机边界

        var dist = (transform.position - Camera.main.transform.position).z;
        var leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).x;
        var rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, dist)).x;
        var topBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).y;
        var bottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, dist)).y;

        transform.position = new Vector3(
          Mathf.Clamp(transform.position.x, leftBorder, rightBorder),
          Mathf.Clamp(transform.position.y, topBorder, bottomBorder),
          transform.position.z
        );

        #endregion
        #region 使飞机重新回到起点

        #endregion
    }
    void FixedUpdate()
    {
        var playerPlane = GetComponent<Rigidbody2D>();
        //让游戏物体移动
        playerPlane.velocity = PlayerMovement;
    }
}
