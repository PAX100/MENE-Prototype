using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class TextRandom : MonoBehaviour {
	public TouchEvent TE;
	public GameObject TheWord;
	public static System.Random ran = new System.Random(Guid.NewGuid().GetHashCode());
	private float FontSize = 90;
	private float speed = 1f;
	public float alpha = 1f;
	private int RanSize;

	//private string[] str = new string[10];
	public List<string> strlist = new List<string>();

	// Use this for initialization
	void Start () {
		TheWord = gameObject;
		//TE.TEDScreen += PrintWord;
		strlist.Add ("龍神の剣を喰え！");
		strlist.Add ("我鎖定你了！");
		strlist.Add ("來對決吧");
		strlist.Add ("Die!Die!Die!");
		strlist.Add ("正義從天而降!");
		strlist.Add ("龍が我が敵を喰らう！");
		strlist.Add ("嗶嗶嗶嗶嗶");
		strlist.Add ("吃我的炸彈");
		strlist.Add ("沒有人能逃出我的雙眼");
		strlist.Add ("凍住，不許走");
		strlist.Add ("爐心超載啦");
		strlist.Add ("炸彈來囉");
		strlist.Add ("來Nerf這招阿");
		strlist.Add ("巫哈哈哈哈哈");
		strlist.Add ("火力全開");
		strlist.Add ("屋轟轟轟轟");
		strlist.Add ("吃我一錘");
		strlist.Add ("英雄永不消逝");
		strlist.Add ("體悟心靈祥和");
		strlist.Add ("熱舞開始");
		strlist.Add ("傳送器運作正常，我開啟通道了");
		PrintWord();


	}
	
	// Update is called once per frame
	void Update () {
		
		//TheWord.GetComponent<Text> ().fontSize = (int)FontSize;


		/*if (TheWord.GetComponent<Text> ().fontSize >= 0) 
		{
			//speed += 0.025f;
			//FontSize -= speed*Time.deltaTime*10;
			//alpha -= 0.002f;
		}*/

	}

	public void PrintWord()
	{
		speed = 1f;	
		//alpha = 0.5f;
		//TheWord.GetComponent<RectTransform> ().anchoredPosition = target;
		int num = ran.Next(0, strlist.Count);
		TheWord.GetComponent<Text> ().text = strlist [num];
		//FontSize = 90;
		RanSize = ran.Next(30,60);
		TheWord.GetComponent<Text> ().fontSize = RanSize;
	}
}
