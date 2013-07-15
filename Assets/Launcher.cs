using UnityEngine;
using System.Collections;

/*
 * Launcher Class
 * This class creates a ball at regular intervals
 * @author kotaoue@gmail.com
 */
public class Launcher : MonoBehaviour {
	public GameObject ballPrefab;
    public float INTERVAL = 10.0f;     	// Time until the next event start
    public float currentTimer = 0.0f;	// Current Timer. when this number becomes 0. event is start.
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        // subtract the current timer.
        // Meaning of deltaTime. it's time from the previous Update method.
        currentTimer -= Time.deltaTime;
        if(currentTimer <= 0.0f) {
        	// Ball is generated on the screen.
			// Initial position equals the MainScene.
			Instantiate(this.ballPrefab, transform.position, transform.rotation);			
			
			// Timer is reset.
			currentTimer = INTERVAL;
        }
		else {
			// print("currentTimer = " + currentTimer + " " + "deltaTime = " + Time.deltaTime);
		}
	}
}
