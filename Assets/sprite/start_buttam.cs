using UnityEngine;
using System.Collections;

public class start_buttam : MonoBehaviour {
	
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();
			
			if (Physics.Raycast(ray, out hit)){
				GameObject obj = hit.collider.gameObject;
				if(obj.name == "start_buttam"){
					Application.LoadLevel(1);
			
				}
			}
		}
	}
}
