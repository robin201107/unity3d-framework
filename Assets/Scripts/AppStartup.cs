using UnityEngine;
using System.Collections;

public class AppStartup : MonoBehaviour {

	void Start () {
        EventMgr.AddReceive(EventMgr.OPERATE_REQUEST, CallbackReceive);
        EventMgr.AddReceive(EventMgr.OPERATE_REQUEST, CallbackReceive2);

        //GameObject.Find("AAA").transform.Find("Cube").GetComponent<PrintTest>().Print();
        //GameObject gameObject = Tool.FindGameObject("AAA/Cube");
        //gameObject.GetComponent<PrintTest>().Print();

	}
	
	void Update () {
        print(GameObject.Find("AAA").transform.Find("Cube").GetComponent<BoxCollider>().size.x);
	}

    private void CallbackReceive(object[] data)
    {
        GameObjectType uType = (GameObjectType)data[0];
        string value = data[1].ToString();
        switch (uType)
        { 
            case GameObjectType.GameObject1:
                break;
            case GameObjectType.GameObject2:
                break;
            case GameObjectType.GameObject3:
                break;
            default:
                break;
        }

        print(uType.ToString() + ": " + value);
    }

    private void CallbackReceive2(object[] data)
    {
        print("aaaaa");
    }
}

