using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonclick : MonoBehaviour {

    private Ray ray;
    private RaycastHit hit;//オブジェクトの情報取得変数
    private GameObject selectedObject;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(1)) SearchRoom();//右クリックを押したとき
    }    
	

    void SearchRoom()
    {
        selectedObject = null;//selectedObjectを空にしておく
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);//メインカメラ上のマウスカーソルのある位置からRayを飛ばす
        if (Physics.Raycast(ray, out hit, Mathf.Infinity,1<<8))//ray：発射位置と方向  Mathf.Infinity距離は無限 
                                                               //1 <<8: 左8ビットシフトしているこれによって8番目のレイヤーにあるオブジェクトにぶつかる
        {
            selectedObject = hit.collider.gameObject;
            switch (selectedObject.name)
            {
                case "Number1"://オブジェクトの名前
                    Debug.Log("1おした");
                    break;
                case "Number2":
                    Debug.Log("２押した");
                    break;
                case "Number3"://
                    Debug.Log("3押した");
                    break;
                case "Number4":
                    Debug.Log("4押した");
                    break;
                case "Number5":
                    Debug.Log("5押した");
                    break;
                case "Number6":
                    Debug.Log("6押した");
                    break;
                case "Number7":
                    Debug.Log("7押した");
                    break;
                case "Number8":
                    Debug.Log("8押した");
                    break;
                case "Number9":
                    Debug.Log("9押した");
                    break;
            }

        }

    }

}
