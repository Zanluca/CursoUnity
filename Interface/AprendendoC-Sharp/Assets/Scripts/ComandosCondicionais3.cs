using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComandosCondicionais3 : MonoBehaviour {

	public int idade;
	public bool idValida;
	public bool compraAutorizada;

	// Use this for initialization
	void Start () {
		if ((idade >= 19 && idValida) || (idade >= 40 )) {
			compraAutorizada = true;
		} 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
