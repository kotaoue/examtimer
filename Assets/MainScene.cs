using UnityEngine;
using System.Collections;
using System;

/*
 * MainScene Class
 * The management of the main scene, a miscellaneous events
 * @author kotaoue@gmail.com
 */
public class MainScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		GUILayout.BeginArea(new Rect(0, 50, Screen.width, 40));
			GUILayout.BeginHorizontal();
				GUILayout.Box(Time.time.ToString(), GUILayout.Width(100));
				GUILayout.FlexibleSpace();
				GUILayout.Box(Mathf.Floor(Time.time / 30).ToString(), GUILayout.Width(100));
			GUILayout.EndHorizontal();
	    GUILayout.EndArea();
	}
}
