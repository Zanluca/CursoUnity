using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcoes : MonoBehaviour {

	//tipo de retorno (matéria prima) nome da funćão (argumentos (maetrias brutas))
	//{
	//}
	public int latidos;
	public int valorA, valorB;
	public float resultado;

	// Use this for initialization
	void Start () {
		//SomarEImprimir (valorA, valorB);
		resultado = Multiplicar(valorA, valorB);
	}

	void Latir(){
		print ("Whoof!");
		latidos++;
	}

	void SomarEImprimir(float a, float b){
		float soma = a + b;
		print ("O resultado da soma e': "+soma);
	}

	float Multiplicar(float valor1, float valor2){
		float multiplicacao = valor1 * valor2;
		return multiplicacao;
	}
	
	// Update is called once per frame
	void Update () {
		//Latir ();
	}
}
