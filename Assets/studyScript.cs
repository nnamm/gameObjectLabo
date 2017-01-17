using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class studyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Z)) {
			// 0.0〜0.5の間の乱数を作り出す
			float rnd = Random.Range(0.0f, 0.5f);
			// 自分（Capsule）の位置を変更
			this.transform.position = new Vector3(0.0f, 0.0f, rnd);
		}

		if(Input.GetKeyDown(KeyCode.Y)) {
			float rnd = Random.Range(0.0f, 360.0f);
			// X軸方向の回転具合をランダムに変更
			this.transform.rotation = Quaternion.Euler(rnd, 0.0f, 0.0f);
		 }

		if(Input.GetKeyDown(KeyCode.X)) {
			float rnd = Random.Range(0.5f, 2.0f);
			// サイズをランダムに変更
			this.transform.localScale = new Vector3(rnd, rnd, rnd);
		 }

		if(Input.GetKey(KeyCode.UpArrow)) {
			this.transform.Translate(new Vector3(0.0f, 0.0f, 3.0f * Time.deltaTime));
		 }
	}
}
