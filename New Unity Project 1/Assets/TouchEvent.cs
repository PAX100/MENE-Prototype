using UnityEngine;
using System.Collections;

public class TouchEvent : MonoBehaviour {

	public delegate void MyTEMD_Object(Transform target);
	public event MyTEMD_Object TEDObject;

	public delegate void MyTEMD_Screen(Vector3 target);
	public event MyTEMD_Screen TEDScreen;

	void Update () {	
		
		if(Input.touchCount > 0){
			for(int i=0; i<Input.touchCount; i++){				
				if(Input.GetTouch(i).phase == TouchPhase.Began){
					Ray touchray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
					RaycastHit hit;

					//Touch Object
					if(Physics.Raycast(touchray, out hit)){
						if(TEDObject != null){							
							TEDObject(hit.transform);	
						}

					}//Physics.Raycast

					//Touch Screen
					if(TEDScreen != null){
						TEDScreen(Input.GetTouch(i).position);
					}

				}

			}
		}

		/*
		if(Input.GetButtonDown("Fire1")){
			Ray touchray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if(Physics.Raycast(touchray, out hit)){
				if(TEDPlayerMove != null){
					TEDPlayerMove(hit.transform);	
				}

			}//Physics.Raycast
			TEDPlayerMove(hit.transform);
		}*/

	}//update
		
}
