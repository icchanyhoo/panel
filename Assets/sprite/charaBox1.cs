using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class charaBox1 : MonoBehaviour {

	public static List<int> numList = new List<int>();
//	public Texture[] select_list;
	public static int texture;
	public static float type;

	void Start () {
		int b = numList[0];
		for(int i = 0;i < 17;i++){
			b = Mathf.Min(b, numList[i]);
		}
		Debug.Log ("min : " + b);
//		Debug.Log("chara_select_list : " + chara_select_list.select1);
//		texture = numList[chara_select_list.select1] - 1;
//		Debug.Log("texture1 : " + texture);
//		this.GetComponent<Renderer>().material.mainTexture = select_list[texture];
	}
}
