using UnityEngine;
using System.Collections;

public class scene_chenge : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// タッチされた時の処理
		Ray ray ;
		RaycastHit hit;
		if (Input.GetMouseButtonDown (0)) {
			ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray.origin, ray.direction, out hit, Mathf.Infinity)) {
				if (hit.collider == gameObject.GetComponent<Collider> ()) {
				
					// チュートリアル表示
					Debug.Log ("scene");

					Application.LoadLevelAsync (1);
				}
			}
		}
	}
}
