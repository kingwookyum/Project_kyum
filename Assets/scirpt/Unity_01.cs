using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Unity_01 : MonoBehaviour
{
    int test = 1;

    // iua = nil
    // C# = null



    // Start is called before the first frame update




    private void OnEnable() // 활성화될때 한번 켜지는 함수 , 이 스크립트를 가진 (컴포넌트로 달린
    {
        Debug.Log("켜졌다.");
    }

    private void OnDisable()
    {
        Debug.Log("꺼졌다.");
    }
    void Start()
    {
      
        //Debug.Log("start");
       // Debug.Log(test);
       // test++;
       // Debug.Log(test);
       // test += 1;
       // Debug.Log(test);
       // test = test + 1;
       // Debug.Log(test);
       // test = test + 1;

    }

    private void OnDestroy()
    {
        
    }

    private void OnApplicationPause(bool pause)
    {
        
    }

    private void OnApplicationQuit()
    {
        
    }
    // Update is called once per frame
    void Update() //매 프레임마다
    {
   
        //Debug.Log("김우겸");
        //Debug.LogWarning ("경고");
        // Debug.LogWarning("ㅇㅇ");







    }
  
}