using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {



    GameObject hoGauge;
	// Use this for initialization
	void Start () {
        this.hoGauge = GameObject.Find("hpGauge");
	}
	
	// Update is called once per frame
	public void DecreaseHp () {
        this.hoGauge.GetComponent<Image>().fillAmount -= 0.1f;
	}
}
