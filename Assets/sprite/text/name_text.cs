using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class name_text : MonoBehaviour {
	
	public Text name;
	public static int select_chara_num;
	
	void Start () {
		//文字列に反映
		name = GetComponent<Text> ();
	}
	
	void Update () {
		//選択したattackステータスを表示
		switch(select_chara_num) {
		case 1 :
			name.text = "No.01";
			break;
		case 2 :
			name.text = "No.02";
			break;
		case 3 :
			name.text = "No.03";
			break;
		case 4 :
			name.text = "No.04";
			break;
		case 5 :
			name.text = "No.05";
			break;
		case 6 :
			name.text = "No.06";
			break;
		case 7 :
			name.text = "No.07";
			break;
		case 8 :
			name.text = "No.08";
			break;
		case 9 :
			name.text = "No.09";
			break;
		case 10 :
			name.text = "No.10";
			break;
		case 11 :
			name.text = "No.11";
			break;
		case 12 :
			name.text = "No.12";
			break;
		case 13 :
			name.text = "No.13";
			break;
		case 14 :
			name.text = "No.14";
			break;
		case 15 :
			name.text = "No.15";
			break;
		case 16 :
			name.text = "No.16";
			break;
		default :
			name.text = "No.00";
			break;
		}
		//選択解除
		if(select_chara_num == 0) {
			name.text = "No.00";
		}
	}
}
