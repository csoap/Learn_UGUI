using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestClick : MonoBehaviour {
	public GameObject ver;
	public InputField input;
	public void Click(){
		var ls = ver.GetComponent<LoopScrollRect>();
		int index = Convert.ToInt32(input.text);
		ls.SrollToCell(index, 1000);
	}
}
