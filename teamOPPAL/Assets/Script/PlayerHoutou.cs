using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHoutou : MonoBehaviour
{
    Plane plane = new Plane();
    float distance = 0;
    // Start is called before the first frame update
    void Start()
    {
        plane.SetNormalAndPosition(Vector3.back, transform.localPosition);
    }

    // Update is called once per frame
    void Update()
    {
        //カメラとマウスの位置をもとにRayを用意
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //プレイヤーの高さにPlaneを更新して、カメラの情報をもとに
        //地面の判定をして距離を取得
        plane.SetNormalAndPosition(Vector3.up, transform.localPosition);
        if (plane.Raycast(ray, out distance))
        {
            //距離をもとに交差を計算し、交点の方を向く
            var lookPoint = ray.GetPoint(distance);
            transform.LookAt(lookPoint);
        }

        

    }

    
    

}
