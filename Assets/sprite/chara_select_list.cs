using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class chara_select_list : MonoBehaviour {

	public static List<int> numList = new List<int>();

	//キャラクター画像格納配列
	public Texture[] select_list;

	//選択したキャラクター表示するオブジェクト
	public GameObject charaBox1;
	public GameObject charaBox2;
	public GameObject charaBox3;
	public GameObject charaBox4;

	public static int texture;

	void Start () {
		for(int i = 0; i < 17; i++){
			texture = numList[i] - 1;
			Debug.Log("texture : " + texture);
			//選択したキャラクターごとに画像を変更
			charaBox1.GetComponent<Renderer>().material.mainTexture = select_list[texture];
		}
	}
}
