using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 渲染扩展
/// </summary>
public static class RendererExtensions
{
    /// <summary>
    /// 检查对象渲染器是否在摄像机的可见范围内
    /// </summary>
    /// <param name="renderer">渲染对象</param>
    /// <param name="camera">摄像机</param>
    /// <returns></returns>
    public static bool IsVisibleFrom(this Renderer renderer, Camera camera)
    {
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
        return GeometryUtility.TestPlanesAABB(planes, renderer.bounds);
    }
}
