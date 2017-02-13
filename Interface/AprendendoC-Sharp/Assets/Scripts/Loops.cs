using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
	public int inteiro;
	// Use this for initialization
	void Start ()
	{
		// objetivo: cirar uma estrutura que faća com que esse inteiro alcae o valor de 100 incrementando de um em um
//		while (inteiro < 100) {
//			// corpo do loop só é executado se inteiro < 100 (condição)
//			inteiro++;
//			print ("O inteiro vale: " + inteiro);
//		}
//		// nesse ponto, o inteiro vale 100.
	
		do
		{
			inteiro ++;
			print ("O inteiro vale: " + inteiro);
		}
		while (inteiro < 100);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
