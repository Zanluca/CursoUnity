using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComandosCondicionais2 : MonoBehaviour {

	public int idade;
	public bool podeBeber, idadeInvalida;

	// Use this for initialization
	void Start () {
		if (idade >= 18) {
			podeBeber = true;
			idadeInvalida = false;
		} else if (idade < 0) {
			podeBeber = false;
			idadeInvalida = true;
		} else {
			podeBeber = false;
			idadeInvalida = false;
		}
		/*
		if (idade >= 18) {
			// executar o que está aqui sempre que idade for maior ou igual a 18
			podeBeber = true;
		} else {
			// executar sempre que a condicao principal não for aceita
			podeBeber = false;
		}
		*/
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
