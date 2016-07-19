using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class RondamNum : MonoBehaviour {
	//TouchEvent
	public TouchEvent TE;
	//Random
	public static System.Random ran = new System.Random(Guid.NewGuid().GetHashCode());
	//GameObject
	public GameObject TheWord;
	//Vector
	public Vector2 TVector;
	private Vector3 velocity = Vector3.zero;
	//Bool
	public bool Moving = false;
	//Num
	public float smoothTime = 5F;
	public float TheWordWidth;
	public float TheWordHeight;

	//Timer
	public float Timer = 0;
	public float Sec = 0;

	// Use this for initialization
	void Start () {
		TheWord = GameObject.Find ("TheWord");
		//TE.TEDScreen += RondamVector3;
		Moving = true;
		//StartCoroutine ("ChangeTVector");

		//Timer
		Timer = Time.time;
		float Sec = 1.7f +(float)ran.NextDouble()*1.7f;
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time - Timer > Sec) {
			
			ChangeTVector ();

			//Timer reset
			Timer = Time.time;
			Sec = 1.7f +(float)ran.NextDouble()*1.7f;
		}

		/*if (Moving == true) 
		{
			dis = Vector3.Distance (Anchors.transform.position, AVector);
			if (dis >= 1000) 
			{
				Anchors.transform.LookAt (AVector);
				//Anchors.transform.localPosition += transform.forward * Time.deltaTime;
			}
		}*/
		if (Moving == true) 
		{
			Vector3 targetPosition = TVector;
			transform.localPosition = Vector3.SmoothDamp(transform.localPosition, targetPosition, ref velocity, smoothTime);
			TheWordWidth = TheWord.GetComponent<RectTransform> ().anchoredPosition.x;
			TheWordHeight = TheWord.GetComponent<RectTransform> ().anchoredPosition.y;
			//Text Moving to Point

		//TheWord.GetComponent<RectTransform> ().anchoredPosition += TVector*Time.deltaTime*5;
		//TheWord.GetComponent<RectTransform> ().anchoredPosition = Vector3.MoveTowards (TheWord.GetComponent<RectTransform> ().anchoredPosition, TVector, Time.deltaTime * 50);
		}
	}

	public void RondamVector3 (Vector3 target)
	{	
		//StopCoroutine ("ChangeTVector");
		do
		{
 		
			float PosX = ran.Next(-800,800);
			float PosY = ran.Next(-1000,1000);
			TVector = new Vector2 (PosX, PosY);
		}while(Vector2.Distance(TVector,new Vector2(TheWordWidth,TheWordHeight))<300);
		//Random X&Y and get into Vector2
			if (TheWord.GetComponent<RectTransform> ().anchoredPosition != TVector) 
			{
				Moving = true;
			}//Start Moving
		//StartCoroutine ("ChangeTVector");
	
	}

	public void ChangeTVector() 
	{
		
		//yield return new WaitForSeconds(Sec);
		float PosX = ran.Next(-200,200);
		float PosY = ran.Next(-600,700);
		TVector = new Vector2 (PosX, PosY);
		//StartCoroutine ("ChangeTVector");
		//Keep Random X&Y and get into Vector2
	}

}
