using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corotina : MonoBehaviour {

	public float segundosDeEspera = 1;

	void Start(){
		StartCoroutine (CorotinaTeste1 (segundosDeEspera));
	}

	// tipo  de acesso - tipo de retorono - nome - parâmetros

	IEnumerator CorotinaTeste (float segundos) {
		//exectua alguns comando
		// espera por alguns segundos
		// volta a executar comandos
		print("Comece a executar uma corotina.");
		yield return new WaitForSeconds (segundos); // esperar por 5 segundos até passar pra linha 15
		print("Depois de "+ segundos + " segundos, volta a executar a funćão normalmente.");
	}

	IEnumerator CorotinaTeste1(float segundos){
		print("Comece a executar uma corotina.");
		float tempoAtual = 0;
		while (tempoAtual < segundos) {
			//passar pro próximo frame;
			tempoAtual += Time.deltaTime; // o tem que o ultimo frame demorou pra se executado.
			print("Esperando...");
			yield return new WaitForEndOfFrame();
		}
		print("Depois de "+ segundos + " segundos, volta a executar a funćão normalmente.");

	}
}
