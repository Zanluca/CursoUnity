using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcoes2 : MonoBehaviour {
	public int[] valores;
	public float valorQualquer;
	public float Dividendo, Divisor, Resto, Quociente; 

	void Start() {
		TrocarValordeIndice (valores, 0, -3);
		SomarComTres (out valorQualquer);
		Quociente = Dividir (Dividendo, Divisor, ref Resto);
	}

	void TrocarValordeIndice (int[] vetor, int indice, int valor){
		vetor [indice] = valor;
	}

	void SomarComTres(out float numero){
		numero = 0;
		numero = numero + 3; // numero+= 3;
	}

	int Dividir (float valor, float divisor, ref float resto){
		// valor / divisor
		// resto = resto da divisão
		resto = 0;
		int quociente = 0;

		while (valor > 0) {
			if (valor - divisor >= 0) {
				quociente++;
				valor = valor - divisor;
			} else {
				resto = valor;
				break;
			}
		}
		//
		return quociente;
	}
}
