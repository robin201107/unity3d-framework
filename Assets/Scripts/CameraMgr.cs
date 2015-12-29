using UnityEngine;
using System.Collections;

public class CameraMgr : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
        if (Input.GetKey("1"))
        {
            //Debug.Log("Using Camera One");
            camSwap((int)CameraType.Camera1);
        }
        if (Input.GetKey("2"))
        {
            //Debug.Log("Using Camera Two");
            camSwap((int)CameraType.Camera2);
        }
        if (Input.GetKey("3"))
        {
            //Debug.Log("Using Camera Three");
            camSwap((int)CameraType.Camera3);
        }
	}

    void camSwap(int currentCam)
    {
        GameObject[] cameras = GameObject.FindGameObjectsWithTag("cam");

        foreach (GameObject cams in cameras)
        {
            //Camera theCam = cams.GetComponent<Camera>() as Camera;
            //theCam.enabled = false;
            //cams.SetActive(false);
            Tool.SetGameObjectEnable<Camera>(cams, false);
        }

        string oneToUse = "Camera" + currentCam;
        string path = "Camera/" + oneToUse;
        //GameObject currentCamera = Tool.FindGameObject("Camera/" + oneToUse);
        Tool.SetGameObjectEnable<Camera>(path, true);

        //Camera usedCam = GameObject.Find(oneToUse).GetComponent<Camera>() as Camera;

        
        //usedCam.enabled = true;
        //transform.Find("Camera/Camera" + currentCam.ToString()).gameObject.SetActive(true);
        //GameObject.Find("Camera").transform.Find("Camera" + currentCam).gameObject.SetActive(true);
        //GameObject.Find("Camera/Camera" + currentCam.ToString()).gameObject.SetActive(true);
        //GameObject.Find("Camera/Camera" + currentCam.ToString()).gameObject.SetActive(true);
        //usedCam.gameObject.SetActive(true);
    }
}


public enum CameraType
{ 
    Camera1 = 1,
    Camera2 = 2,
    Camera3 = 3
}