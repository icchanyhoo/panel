using UnityEngine;
using System.Collections;

public class chara3 : MonoBehaviour {
	
	//適用テクスチャ
	public Texture tapOn;
	public Texture tapOff;
	
	//テクスチャ切り替えフラグ
	public static int change_flag = 0;
	
	//ステータス
	public static int attack = 30;
	public static int defense = 30;
	public static int element_type = 3;
	public static int life = 10;
	
	public static int chara_num;

	void Start () {
		//キャラクター選択フラグリセット
		change_flag = 0;
	}

	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();
			
			if (Physics.Raycast(ray, out hit)){
				GameObject obj = hit.collider.gameObject;
				if(obj.name == "chara3"){
					if(change_flag == 0 && chara_count.count < 4){
						
						//テクスチャ切り替えON
						change_flag = 1;
						GetComponent<Renderer>().material.mainTexture = tapOn;
						Debug.Log("tapOn : " + change_flag);
						
						//選択中のキャラクターナンバー（0の場合は無選択）
						chara_num = 3;
						Debug.Log("chara_num : " + chara_num);
						
						//選択上限カウント
						chara_count.count++;
						Debug.Log("chara_count : " + chara_count.count);

						//attackに加算
						attack_type_green.add_chara3 = attack;
						Debug.Log("attack_add : " + attack_type_green.add_chara3);

						//defenseに加算
						defense_add_count.add_chara3 = defense;
						Debug.Log("life_add : " + defense_add_count.add_chara3);
						
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

						//attackに減算
						attack_type_green.add_chara3 = 0;

						//defenseに減算
						defense_add_count.add_chara3 = 0;
					} 
				}
				Debug.Log(obj.name);
			}
		}
	}		
}
