using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	// Use this for initialization
	void Start() {
		this.rigidbody.velocity = new Vector3(0.0f, 0.0f, 0.0f);
		// print(this.position.z);
	}
	
	// Update is called once per frame
	void Update() {
	
	}

    /*
     * 画面外にオブジェクトが出たとき。
     */
	void OnBecameInvisible() {
		// オブジェクトを削除
        Destroy(this.gameObject);
    }
}
