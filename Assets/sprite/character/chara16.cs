﻿using UnityEngine;
using System.Collections;

public class chara16 : MonoBehaviour {
	
	//適用テクスチャ
	public Texture tapOn;
	public Texture tapOff;
	
	//テクスチャ切り替えフラグ
	public static int change_flag = 0;
	
	//ステータス
	public static int attack = 40;
	public static int defense = 30;
	public static int element_type = 4;
	public static int life = 20;
	
	public static int chara_num;
	
	void Start () {
		//キャラクター選択フラグリセット
		change_flag = 0;

		//攻撃力＆HPステータスをリセット
		attack_type_yellow.add_chara16 = 0;
		defense_add_count.add_chara16 = 0;
		attack_status_text.select_chara_num = 0;
		life_status_text.select_chara_num = 0;
		name_text.select_chara_num = 0;
	}
	
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();
			
			if (Physics.Raycast(ray, out hit)){
				GameObject obj = hit.collider.gameObject;
				if(obj.name == "chara16"){
					if(change_flag == 0 && chara_count.count < 4){
						
						//テクスチャ切り替えON
						change_flag = 1;
						GetComponent<Renderer>().material.mainTexture = tapOn;
						Debug.Log("tapOn : " + change_flag);
						
						//選択中のキャラクターナンバー（0の場合は無選択）
						chara_num = 16;
						Debug.Log("chara_num : " + chara_num);
						attack_status_text.select_chara_num = chara_num;
						life_status_text.select_chara_num = chara_num;
						name_text.select_chara_num = chara_num;

						//プレイ画面にキャラクターをセット（仮実装）
						//chara_select_list.numList.Add(chara_num);

						//選択上限カウント
						chara_count.count++;
						Debug.Log("chara_count : " + chara_count.count);
						
						//attackに加算
						attack_type_yellow.add_chara16 = attack;
						Debug.Log("attack_add : " + attack_type_yellow.add_chara16);
						
						//defenseに加算
						defense_add_count.add_chara16 = defense;
						Debug.Log("life_add : " + defense_add_count.add_chara16);
						
					} else if(change_flag == 1){
						
						//テクスチャ切り替えOFF
						change_flag = 0;
						GetComponent<Renderer>().material.mainTexture = tapOff;
						Debug.Log("tapOff : " + change_flag);
						
						//選択中のキャラクターナンバー（0の場合は無選択）
						chara_num = 0;
						Debug.Log("chara_num : " + chara_num);
						attack_status_text.select_chara_num = 0;
						life_status_text.select_chara_num = 0;
						name_text.select_chara_num = 0;
						
						//選択上限カウント
						chara_count.count--;
						Debug.Log("chara_count : " + chara_count.count);
						
						//attackに減算
						attack_type_yellow.add_chara16 = 0;
						
						//defenseに減算
						defense_add_count.add_chara16 = 0;
					} 
				}
				Debug.Log(obj.name);
			}
		}
	}
}
