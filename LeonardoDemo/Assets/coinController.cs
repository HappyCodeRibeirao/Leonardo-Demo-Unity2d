using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinController : MonoBehaviour {
	int vidas = 4;
	string nomeHeroi = "Jon";
	// Use this for initialization
	void Start () {
		Debug.Log (falarNome ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public string falarNome()
	{
		return nomeHeroi;

	}

}
