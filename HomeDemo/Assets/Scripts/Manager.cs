using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
    public GameObject housePlan;
	private void OnGUI()
    {
        if(GUILayout.Button("開關平面圖"))
        {
            housePlan.SetActive(!housePlan.activeInHierarchy);
        }
    }
}
