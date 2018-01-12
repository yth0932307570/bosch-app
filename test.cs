using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	public struct XXX
	{
		public static int aaa;

		public GameObject mPCube;

		public GameObject mCube;
	}

	public static int aaa;

	public GameObject mPCube;

	public GameObject mCube;

	private Vector2 xy;

	public delegate void TTT(int a);
	public TTT mxx;

	// Use this for initialization
	void Start (Main x, XXX y) {

		XXX m = y;
		m.mPCube = bbb;

		aaa = 10;

		GameObject.DontDestroyOnLoad (this.gameObject);

		PlayerPrefs.SetFloat ("xxx", 10);

		Resources.Load ("images/bk");

		xy = new Vector2 (1, 1);
		xy.x;
		xy.y;

		string path = Application.absoluteURL+"//";
		//Application.dataPath;
		WWW www = new WWW (path);
		www.texture;

		GameObject obj = GameObject.Instantiate (mPCube);

		this.gameObject.GetComponent<Camera> ();

		this.transform.Find ("Cube");

		new Vector3Int ();

		transform.position = new Vector3 (1, 1, 1);
		float s = 0.5f;
		transform.localScale = new Vector3 (s, 1, s);
	}

	public void Onclick(){
	//查　　開啟網頁的程式與法
	}
	// Update is called once per frame
	void Update () {
		
	}
}
