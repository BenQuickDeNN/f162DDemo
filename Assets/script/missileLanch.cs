using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileLanch : MonoBehaviour {
    #region 1 - 变量

    /// <summary>
    /// 子弹预设
    /// </summary>
    public Transform shotPrefab;

    /// <summary>
    /// 两发子弹之间的发射间隔时间
    /// </summary>
    public float shootingRate = 0.25f;

    /// <summary>
    /// 当前冷却时间
    /// </summary>
    private float shootCooldown;

    #endregion
    // Use this for initialization
    void Start () {
        // 初始化冷却时间为0
        shootCooldown = 0f;
    }
	
	// Update is called once per frame
	void Update () {
        // 冷却期间实时减少时间
        if (shootCooldown > 0)
        {
            shootCooldown -= Time.deltaTime;
        }
        #region 射击控制

        // 5 - 射击
        bool shoot = Input.GetButtonDown("Fire1");
        shoot |= Input.GetButtonDown("Fire2");
        // 小心：对于Mac用户，按Ctrl +箭头是一个坏主意

        if (shoot)
        {
            missileLanch weapon = GetComponent<missileLanch>();
            if (weapon != null)
            {
                weapon.Attack(false);
            }
        }

        #endregion
    }
    /// <summary>
    /// 射击
    /// </summary>
    /// <param name="isEnemy">是否是敌人的子弹</param>
    public void Attack(bool isEnemy)
    {
        if (CanAttack)
        {
            if (isEnemy)
            {
                //SoundEffectsHelper.Instance.MakeEnemyShotSound();
            }
            else
            {
                //SoundEffectsHelper.Instance.MakePlayerShotSound();
            }

            shootCooldown = shootingRate;

            // 创建一个子弹
            var shotTransform = Instantiate(shotPrefab) as Transform;

            // 指定子弹位置
            shotTransform.position = transform.position;

            // 设置子弹归属
            missileShot shot = shotTransform.gameObject.GetComponent<missileShot>();
            shot.isClone = true;

            // 设置子弹运动方向
            ScrollingScript move = shotTransform.gameObject.GetComponent<ScrollingScript>();
            if (move != null)
            {
                // towards in 2D space is the right of the sprite
                move.direction = this.transform.right;
            }
        }
    }

    /// <summary>
    /// 武器是否准备好再次发射
    /// </summary>
    public bool CanAttack
    {
        get
        {
            return shootCooldown <= 0f;
        }
    }
}
