using UnityEngine;
using System.Collections;

public class start_buttam : MonoBehaviour {

	void Start () {
		chara_count.count = 0;
	}
	
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();
			
			if (Physics.Raycast(ray, out hit)){
				GameObject obj = hit.collider.gameObject;
				if(obj.name == "start_buttam"){
					if(chara_count.count == 4){
						Application.LoadLevel(1);
					}
				}
			}
		}
	}
}
