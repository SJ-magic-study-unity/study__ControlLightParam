/************************************************************
query = unity light script

Light.intensity
	https://docs.unity3d.com/jp/current/ScriptReference/Light-intensity.html
	
Light.color
	https://docs.unity3d.com/jp/current/ScriptReference/Light-color.html
************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************************
************************************************************/
public class ControlLightParam : MonoBehaviour {
	[SerializeField] Light light; // 本scriptをLight object以外にattachし、外部から設定する場合.
	Color col;
	
	void Start () {
		// light = GetComponent<Light>(); // 本scriptをLight objectにattachする場合.
		
		col = new Color(1.0f, 1.0f, 0.0f, 1.0f);
		light.color = col;
		
		light.intensity = 2.0f;
	}
	
	void Update () {
		
	}
}
