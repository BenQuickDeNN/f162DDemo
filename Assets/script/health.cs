using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour {
    #region 1 - 变量

    /// <summary>
    /// 总生命值
    /// </summary>
    public int hp = 1;

    /// <summary>
    /// 敌人标识
    /// </summary>
    public bool isEnemy = true;
    /// <summary>
    /// 对敌人造成伤害并检查对象是否应该被销毁
    /// </summary>
    /// <param name="damageCount"></param>
    public void Damage(int damageCount)
    {
        hp -= damageCount;
        SpecialEffectsHelper.Instance.Explosion(transform.position);
        SoundEffectsHelper.Instance.MakeExplosionSound();
        if (hp <= 0)
        {
            // 死亡! 销毁对象!
            Destroy(gameObject);
            
        }
    }
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        missileShot shot = otherCollider.gameObject.GetComponent<missileShot>();
        if (shot != null)
        {
            Damage(shot.damage);

            // 销毁子弹
            // 记住，总是针对游戏的对象，否则你只是删除脚本
            
            Destroy(shot.gameObject);
            
        }
    }
    #endregion
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
