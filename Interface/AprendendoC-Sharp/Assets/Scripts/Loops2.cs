using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops2 : MonoBehaviour {

	public string[] textos;

	// Use this for initialization
	void Start () {
		/*for (int varLocal = 1; varLocal <= 10; varLocal++) {
			int multiploAtualDe3 = varLocal * 3;
			print (multiploAtualDe3);
		}*/

//		for (int indice = 0; indice < textos.Length; indice++) {
//			print (textos [indice]);
//		}

		//forma compacta de iterar (passar por) todos os elemntos de um array
		foreach (string s in textos) {
			print (s);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
