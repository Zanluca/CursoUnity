using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

	public int[] arrayDeInteiros;
	public int valorQualquer;

	// Use this for initialization
	void Start () {
		arrayDeInteiros [0] = -3;
		arrayDeInteiros [3] = 7;
		valorQualquer = arrayDeInteiros [5];
		int posicaoDoVetor = 0;
		while (posicaoDoVetor < arrayDeInteiros.Length) {
			arrayDeInteiros [posicaoDoVetor] = posicaoDoVetor * 2;
			posicaoDoVetor++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
