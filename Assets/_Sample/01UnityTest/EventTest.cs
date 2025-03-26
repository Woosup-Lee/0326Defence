using UnityEngine;
using System.Collections.Generic;

public class EventTest : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("🎉🎉WELCOME! Awake 실행 |ヽ(*￣▽￣*)ノミ|🎉🎉");
    }
    

    //Onenable은 1회실행
    private void OnEnable()
    {
        Debug.Log("OnEnable 실행 난 딱 한번만 나올꺼야");
    }

    private void Start()
    {
        Debug.Log("Start! 💕");
    }
    //FixedUpdate에서부터 OnApplicationQuit까지 가고 한바퀴 다시 돌아올때 한 프레임 순환했다함.
    //FixedUpdate는 1초에 50프레임 고정
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate가 또 나오게 되😫");
    }

    //Update는 매 프레임마다 호출
    private void Update()
    {
        Debug.Log("앙 Update실행띠 ☆*: .｡. o(≧▽≦)o .｡.:*☆");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate 따라와또 🥺 ");
    }

    //Disable은 비활성화할때 딱 한번 실행
    private void OnDisable()
    {
        Debug.Log("OnDisaable 실행 나도 딱 한번만 나올꺼야");
    }

    //얘도 딱 한번 실행
    private void OnDestroy()
    {
        Debug.Log("onDestroy!!!! 다 부숴버렷!! 딱 한번 내손안에 모든것이 소멸될지니!!! 😆");
    }
}
