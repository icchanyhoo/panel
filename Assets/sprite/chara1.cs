using UnityEngine;
using System.Collections;

public class chara1 : MonoBehaviour {

	//適用テクスチャ
	public Texture tapOn;
	public Texture tapOff;

	//テクスチャ切り替えフラグ
	public static int change_flag = 0;

	//ステータス
	public static int attack;
	public static int defense;
	public static int element_type;
	public static int life;

	public static int chara_num;

	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();
			
			if (Physics.Raycast(ray, out hit)){
				GameObject obj = hit.collider.gameObject;
				if(obj.name == "chara1"){
					if(change_flag == 0 && chara_count.count <= 5){

						//テクスチャ切り替えON
						change_flag = 1;
						GetComponent<Renderer>().material.mainTexture = tapOn;
						Debug.Log("tapOn : " + change_flag);

						//選択中のキャラクターナンバー（0の場合は無選択）
						chara_num = 1;
						Debug.Log("chara_num : " + chara_num);

						//選択上限カウント
						chara_count.count++;
						Debug.Log("chara_count : " + chara_count.count);

					} else if(change_flag == 1){

						//テクスチャ切り替えOFF
						change_flag = 0;
						GetComponent<Renderer>().material.mainTexture = tapOff;
						Debug.Log("tapOff : " + change_flag);

						//選択中のキャラクターナンバー（0の場合は無選択）
						chara_num = 0;
						Debug.Log("chara_num : " + chara_num);

						//選択上限カウント
						chara_count.count--;
						Debug.Log("chara_count : " + chara_count.count);
					} 
				}
				Debug.Log(obj.name);
			}
		}
	}

	//ステータスメソッド
	void status_chara1(){
		attack = 20;
		defense = 10;
		element_type = 1;
		life = 10;
	}
}
