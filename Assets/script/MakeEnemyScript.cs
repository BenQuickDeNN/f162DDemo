using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeEnemyScript : MonoBehaviour {

    /// <summary>
    /// 敌人预设体
    /// </summary>
    public Transform enemyPrefab;

    // Use this for initialization
    public int maxEnemyAmount = 7;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount < maxEnemyAmount)
        {
            CreateEnemy();
        }
    }

    /// <summary>
    /// 创建敌人
    /// </summary>
    void CreateEnemy()
    {
        var enemyTransform = Instantiate(enemyPrefab) as Transform;
        enemyTransform.position = new Vector3(Camera.main.transform.position.x + 40, Random.Range(-4, 4), 0);
        enemyTransform.transform.parent = transform;
        ScrollingScript move = enemyTransform.gameObject.GetComponent<ScrollingScript>();
        if (move != null)
        {
            move.direction.x = -1f;
            move.speed = new Vector2(3, 3);
        }
    }
}
