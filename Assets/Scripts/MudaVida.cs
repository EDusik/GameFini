﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudaVida : MonoBehaviour {

    //public float vida = 100;
    //public Image BarraVida;

    // Use this for initialization
    void Start () {
        //BarraVida.fillAmount = (vida / 100);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col) {
        //if (col.tag == "trash" || col.tag == "tire") {
        //    vida -= 20;
        //    BarraVida.fillAmount = (vida / 100);
        //    if (vida < 1) {
        //        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        //    }
        //}
    }
}
