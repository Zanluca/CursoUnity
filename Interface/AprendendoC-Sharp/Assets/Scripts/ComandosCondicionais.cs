using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComandosCondicionais : MonoBehaviour {

	public bool condicao; // pode ser true ou false
	public int idade;

	// Use this for initialization
	void Start () {
		if (condicao) {
			// tudo que estiver enre esssa chaves vai ser executado quando condicao for verdadeira
			idade = 0;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
