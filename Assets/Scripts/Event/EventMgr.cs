using UnityEngine;
using System.Collections;

public class EventMgr {

    public const string OPERATE_REQUEST = "operate_request";
    public const string OPERATE_NOTIFIED = "operate_notified";

    private static EventDispatcher eventDispatcher = new EventDispatcher();
    public static void AddReceive(string msg, CallBack callback)
    {
        eventDispatcher.AddListener(msg, callback);
    }

    public static void RemoveReceive(string msg, CallBack callback)
    {
        eventDispatcher.RemoveListener(msg, callback);
    }

    public static void Notify(string msg, params object[] data)
    {
        eventDispatcher.Dispatch(msg, data);
    }
}

public enum GameObjectType
{ 
    GameObject1,
    GameObject2,
    GameObject3
}