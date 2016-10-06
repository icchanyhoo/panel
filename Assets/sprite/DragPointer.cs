using UnityEngine;
using System.Collections;

public class DragPointer : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		// マウス左クリック時
		if (Input.GetMouseButton(0))
		{
			Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane + 0.01f);
			
			gameObject.transform.position = Camera.main.ScreenToWorldPoint(screenPosition);
		}
	}
}
