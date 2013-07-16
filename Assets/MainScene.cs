using UnityEngine;
using System.Collections;
using System;

/*
 * MainScene Class
 * The management of the main scene, a miscellaneous events
 * @author kotaoue@gmail.com
 */
public class MainScene : MonoBehaviour {
	public GUIStyle guiStyle;
	private float startTime;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			startTime = Time.time;
		}	
	}
	
	private void OnGUI() {
		GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height * 0.25f));
			GUILayout.BeginHorizontal();
				GUILayout.Label(Mathf.Floor((Time.time - startTime) % 30.0f).ToString(), guiStyle, GUILayout.Width(Screen.width * 0.95f));
				GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			
			GUILayout.FlexibleSpace();
		
			GUILayout.BeginHorizontal();
				GUILayout.Label(Mathf.Floor((Time.time - startTime) / 30.0f).ToString(), guiStyle, GUILayout.Width(Screen.width * 0.95f));
				GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
	    GUILayout.EndArea();
	}

}
