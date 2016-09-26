using UnityEngine;
using System.Collections;

public class UIRoot : MonoBehaviour {
	public int manualWidth = 1280;
	public int manualHeight = 720;
	
	UIRoot uiRoot_;
	
	void Awake()
	{
		uiRoot_ = GetComponent<UIRoot>();
	}
	
	void Update ()
	{
		if(!uiRoot_ || manualWidth <= 0 || manualHeight <= 0){ return; }
		
		int h = manualHeight;
		float r = (float)(Screen.height * manualWidth) / (Screen.width * manualHeight); // (Screen.height / manualHeight) / (Screen.width / manualWidth)
		if(r  > 1){ h = (int)(h * r); } // to pretend target height is more high, because screen width is too smaller to show all UI
		

		if(uiRoot_.manualHeight != h){ uiRoot_.manualHeight = h; }
	}
}
