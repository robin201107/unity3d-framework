using UnityEngine;
using System.Collections;

public static class Tool {
    public static GameObject FindGameObject(string path)
    {
        return GameObject.Find(path);
    }

    public static GameObject FindGameObjectWithTransform(Transform transform, string path)
    {
        return transform.Find(path).gameObject;
    }

    public static void SetGameObjectActive(GameObject gameObject, bool isActive)
    {
        gameObject.SetActive(isActive);
    }

    public static void SetGameObjectEnable<T>(GameObject gameObject,  bool isEnable) where T : Behaviour
    {
        Behaviour behaviour = gameObject.GetComponent<T>() as Behaviour;
        behaviour.enabled = isEnable;
    }

    public static void SetGameObjectEnable<T>(string path, bool isEnable) where T : Behaviour
    {
        GameObject gameObject = Tool.FindGameObject(path);
        Tool.SetGameObjectEnable<T>(gameObject, isEnable);
    }
}
