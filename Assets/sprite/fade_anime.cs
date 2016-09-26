using UnityEngine;
using System.Collections;

public class fade_anime : MonoBehaviour {

	//ゲームが始まった際にAnimationを再生させる
	void Start () {
		GetComponent<Animator>().SetTrigger("fade_logo");
		Invoke ("Update",6f);
	}

	void Update(){
		Ray ray;
		RaycastHit hit;
		if (Input.GetMouseButtonDown (0)) {
			ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray.origin, ray.direction, out hit, Mathf.Infinity)) {
				if (hit.collider == gameObject.GetComponent<Collider> ()) {

					GetComponent<Animator> ().SetTrigger ("fade_tutorial");
					if (Input.GetMouseButtonDown (0)) {
						Debug.Log ("ok");
						Application.LoadLevel ("game");
					}
				}
			}
		}
	}
}
