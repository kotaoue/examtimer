using UnityEngine;
using System.Collections;
using System;

/*
 * Gui Class
 * Class for processing of Gui Layout.
 * @author kotaoue@gmail.com
 */
public class Gui : MonoBehaviour {
	public GUIStyle guiStyle;
	
	private void OnGUI() {
		// Make normal clock.
		// GUILayout.Box(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), GUILayout.Width(Screen.width));
		/*
		GUILayout.BeginArea(new Rect(0, 0, Screen.width, 40));
			GUILayout.BeginHorizontal();
				GUILayout.FlexibleSpace();
				GUILayout.Box(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), GUILayout.Width(200));
			GUILayout.EndHorizontal();
	    GUILayout.EndArea();
	    */
		
		GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height * 0.25f));
			GUILayout.BeginHorizontal();
				GUILayout.Label(Mathf.Floor(Time.time).ToString(), guiStyle, GUILayout.Width(Screen.width * 0.95f));
				GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			
			GUILayout.FlexibleSpace();
		
			GUILayout.BeginHorizontal();
				GUILayout.Label(Mathf.Floor(Time.time / 30).ToString(), guiStyle, GUILayout.Width(Screen.width * 0.95f));
				GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
	    GUILayout.EndArea();
	}
}
