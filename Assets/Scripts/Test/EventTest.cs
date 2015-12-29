using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EventTest : MonoBehaviour
{
    public Button btn;

    private void Awake()
    {
        btn.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        EventMgr.Notify(EventMgr.OPERATE_REQUEST, GameObjectType.GameObject2, "123456");
    }
}
