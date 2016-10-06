using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class main : MonoBehaviour{
	
	public GameObject panelPrefab;
	// ターン切り替え
	public GameObject ene_turnBox;
	// スライドインアウト
	public GameObject srider_in_outBox;
	// タッチオブジェクト
	public static GameObject hitObj;
	public static GameObject panel;
	// パネル配列ID
	public static int spriteId;
	public Sprite[] panelSprites;
	// パネルタッチ範囲
	private GameObject firstPanel;
	private GameObject lastPanel;
	private string currentName;
	// エネミーパネル
	private string ene_panel;
	// 削除パネル
	List<GameObject>removablePanelList = new List<GameObject>();
	// 判定フラグ
	public static int turn = 0;
	public static int srider_inout_frag = 0;
	public static float damegePoint = 0;
	public static int turn_seec = 0;
	public static int Drag_frag = 0;

	//tameshi
	private GameObject color_return_panel0;
	private GameObject color_return_panel1;
	private GameObject color_return_panel2;
	private GameObject color_return_panel3;
	private GameObject color_return_panel4;

	void Start(){
		// スライドインアウト
		FlagManager.Instance.flags[0] = true;

		Debug.Log ("flag[0]");

		srider_in_outBox.SendMessage ("Scroll");
	}

	void Drop(){
		// パネルドロップ
		StartCoroutine(DropPanel(42));
	}

	//パネル生成
	IEnumerator DropPanel(int count){
		for(int i = 0; i < count; i++){
			Vector2 pos = new Vector2(Random.Range(-2.0f, 2.0f), 7f);
			panel = Instantiate(panelPrefab, pos,
			                   Quaternion.AngleAxis(Random.Range(-40, 40), Vector3.forward)) as GameObject;
			spriteId = Random.Range(0, 5);
			panel.name = "Panel" + spriteId;
			SpriteRenderer spriteObj = panel.GetComponent<SpriteRenderer>();
			spriteObj.sprite = panelSprites[spriteId];
			yield return new WaitForSeconds(0.05f);
			if(panel.name == "Panel4"){
				damegePoint += eneBox.ene_attack;
			}
		}
	}


	void Update(){
		//マイターン
		if (turn == 0) {
			if (Input.GetMouseButtonDown (0) && firstPanel == null) {
				OnDragStart ();
			} else if (Input.GetMouseButtonUp (0)) {
				if (firstPanel != null) {
				OnDragEnd ();
				}
			} else if (firstPanel != null) {
				OnDragging ();
			}
			//エネミーターン
		}else if(turn == 1){
			lifePoint.my_life -= damegePoint;

			Debug.Log("ene_hantei" + damegePoint);
			Debug.Log("my_life" + lifePoint.my_life);

			FlagManager.Instance.flags[2] = true;

			Debug.Log ("flag[2]");

			srider_in_outBox.SendMessage("Scroll");
		}
	}

	//====ドラッグ開始＝ここから====
	private void OnDragStart(){
		RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
		if(hit.collider != null){
			hitObj = hit.collider.gameObject;
			string ballName = hitObj.name;
			if(ballName.StartsWith("Panel")){
				firstPanel = hitObj;
				lastPanel = hitObj;
				currentName = hitObj.name;
				removablePanelList = new List<GameObject>();
				PushToList(hitObj);
			}
		}
		Debug.Log ("OnDragStart");
	}
	
	private void OnDragging()
	{
		RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
		if (hit.collider != null) {
			GameObject hitObj = hit.collider.gameObject;
			if (hitObj.name == currentName && lastPanel != hitObj) {
				float distance = Vector2.Distance (hitObj.transform.position, lastPanel.transform.position);
				if (distance < 1.5f) {
					lastPanel = hitObj;
					PushToList (hitObj);
				}
			}
		} else {
			OnDragStart();
		}
	}
	
	private void OnDragEnd(){
		int remove_cnt = removablePanelList.Count;
		if (remove_cnt >= 3) {
			for (int i = 0; i < remove_cnt; i++) {
				Destroy (removablePanelList [i]);
				if(currentName == "Panel4"){
					damegePoint -= eneBox.ene_attack;
				}
			}
			Debug.Log("OnDragEnd");

			// パネル属性判別エネミーに与えるダメージ
			if(currentName == "Panel0"){
				// 火属性ダメージをエネミーに与える

				Debug.Log("red_type");

				if(charaBox1.type == 1 || charaBox2.type == 1 || charaBox3.type == 1 || charaBox4.type == 1){
					lifePoint.ene_life -= attack_type_red.my_damegePoint;
				}

				Debug.Log("my_damePoint" + attack_type_red.my_damegePoint);

			}else if(currentName == "Panel1"){
				// 水属性ダメージをエネミーに与える

				Debug.Log("bull_type");

				if(charaBox1.type == 2 || charaBox2.type == 2 || charaBox3.type == 2 || charaBox4.type == 2){
					lifePoint.ene_life -= attack_type_bull.my_damegePoint;
				}

				Debug.Log("my_damePoint" + attack_type_bull.my_damegePoint);

			}else if(currentName == "Panel2"){
				// 風属性ダメージをエネミーに与える

				Debug.Log("green_type");

				if(charaBox1.type == 3 || charaBox2.type == 3 || charaBox3.type == 3 || charaBox4.type == 3){
					lifePoint.ene_life -= attack_type_green.my_damegePoint;
				}

				Debug.Log("my_damePoint" + attack_type_green.my_damegePoint);

			}else if(currentName == "Panel3"){
				// 光属性ダメージをエネミーに与える

				Debug.Log("yellow_type");

				if(charaBox1.type == 4 || charaBox2.type == 4 || charaBox3.type == 4 || charaBox4.type == 4){
					lifePoint.ene_life -= attack_type_yellow.my_damegePoint;
				}

				Debug.Log("my_damePoint" + attack_type_yellow.my_damegePoint);

			}

			//ボールを新たに生成
			StartCoroutine (DropPanel (remove_cnt));

			//ターン判定と遷移
			FlagManager.Instance.flags[1] = true;
			srider_in_outBox.SendMessage("Scroll");
		} else if (remove_cnt < 3) {
			remove_cnt = 0;
			//currentName = null;
			firstPanel = null;
			lastPanel = null;
			Debug.Log("return_myturn");
			//Update();
			panelCount();

		} else {
			for (int i = 0; i < remove_cnt; i++) {
				ChangeColor (removablePanelList [i], 1.0f);
			}
			firstPanel = null;
			lastPanel = null;
		}
	}

	
	void PushToList(GameObject obj){
		removablePanelList.Add(obj);
		//色の透明度を50%に落とす
		ChangeColor(obj, 0.5f);
		Debug.Log("changeColor");
	}

	void ChangeColor (GameObject obj, float transparency) {
		//SpriteRendererコンポーネントを取得
		SpriteRenderer ballTexture = obj.GetComponent<SpriteRenderer>();
		//Colorプロパティのうち、透明度のみ変更する
		ballTexture.color = new Color(ballTexture.color.r, ballTexture.color.g, ballTexture.color.b, transparency);
		Debug.Log ("changeColor_transparency");
	}

	//tameshi
	GameObject[] enemyObjects;
	int panel_count_number;
	void panelCount ()
	{
		enemyObjects = GameObject.FindGameObjectsWithTag ("panel_count");
		panel_count_number =enemyObjects.Length;
		panel_color_return();
	}

	//色の透明度を100%に戻す tameshi
	void panel_color_return() {
		for (int i = 0; i < panel_count_number; i++) {
			color_return_panel0 = GameObject.Find ("Panel0");
			color_return_panel0.GetComponent<SpriteRenderer> ().color = new Color (1.0f, 1.0f, 1.0f, 1.0f);
			Debug.Log ("tameshi_pushu : " + color_return_panel0);
			color_return_panel1 = GameObject.Find ("Panel1");
			color_return_panel1.GetComponent<SpriteRenderer> ().color = new Color (1.0f, 1.0f, 1.0f, 1.0f);
			Debug.Log ("tameshi_pushu : " + color_return_panel1);
			color_return_panel2 = GameObject.Find ("Panel2");
			color_return_panel2.GetComponent<SpriteRenderer> ().color = new Color (1.0f, 1.0f, 1.0f, 1.0f);
			Debug.Log ("tameshi_pushu : " + color_return_panel2);
			color_return_panel3 = GameObject.Find ("Panel3");
			color_return_panel3.GetComponent<SpriteRenderer> ().color = new Color (1.0f, 1.0f, 1.0f, 1.0f);
			Debug.Log ("tameshi_pushu : " + color_return_panel3);
			color_return_panel4 = GameObject.Find ("Panel4");
			color_return_panel4.GetComponent<SpriteRenderer> ().color = new Color (1.0f, 1.0f, 1.0f, 1.0f);
			Debug.Log ("tameshi_pushu : " + color_return_panel4);
			Debug.Log("panel_count_number : " + panel_count_number);
		}
		Update ();
	}		
}
//====ドラッグ開始＝ここまで====