using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialEffectsHelper : MonoBehaviour {

    /// <summary>
    /// Singleton
    /// </summary>
    public static SpecialEffectsHelper Instance;

    public ParticleSystem smokeEffect;
    public ParticleSystem fireEffect;

    void Awake()
    {
        // Register the singleton
        if (Instance != null)
        {
            Debug.LogError("Multiple instances of SpecialEffectsHelper!");
        }

        Instance = this;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// 在给定位置创建爆炸特效
    /// </summary>
    /// <param name="position"></param>
    public void Explosion(Vector3 position)
    {
        // 烟雾特效
        instantiate(smokeEffect, position);
        // 火焰特效
        instantiate(fireEffect, position);
    }

    /// <summary>
    /// 从预制体中实例化粒子特效
    /// </summary>
    /// <param name="prefab"></param>
    /// <returns></returns>
    private ParticleSystem instantiate(ParticleSystem prefab, Vector3 position)
    {
        ParticleSystem newParticleSystem = Instantiate(prefab, position, Quaternion.identity) as ParticleSystem;

        // 确保它会被销毁
        Destroy(newParticleSystem.gameObject, newParticleSystem.startLifetime);

        return newParticleSystem;
    }
}
