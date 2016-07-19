using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class ColorRandom : MonoBehaviour {
	public static System.Random ran = new System.Random(Guid.NewGuid().GetHashCode());
	public GameObject TheWord;
	public Color MaxColor;
	public Color MinColor;
	public float StealthTime;
	// Use this for initialization
	void Start () {
		TheWord = gameObject;
		StealthTime = 0.5f +(float)ran.NextDouble();
		MaxColor = Color.red;
		MinColor = Color.clear;
		//MaxColor = new Vector4 ((float)ran.NextDouble(), (float)ran.NextDouble(), (float)ran.NextDouble(), 1);
		//MinColor = new Vector4 ((float)ran.NextDouble(), (float)ran.NextDouble(), (float)ran.NextDouble(), 0);
	}
	
	// Update is called once per frame
	void Update () {
		TheWord.GetComponent<Text> ().color = Color.Lerp(MaxColor, MinColor, Mathf.PingPong(Time.time,StealthTime));
	
	}
}
