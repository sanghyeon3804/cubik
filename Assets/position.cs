 cdusing System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //hide 명령어
        GameObject obj0 = GameObject.Find("shape_cube");
        Vector3 pos;
        pos = obj0.GameObject.transform.position;
        
        for (int i = 0; i < 5; i++)
        {
            for (int k = 0; k < 5; k++)
            {
                for (int r = 0; r < 8; r++)
                {
                   
                    if (pos.x == i && pos.z == k && pos.y == r)
                    {
                       obj0.SetActive(false);
                    }
                }
            }
        }


    }


    // Update is called once per frame
    void Update()
    {
        // 배열 오브젝트끼리 공유 하 기
        //temporary array would defined: bool position[x][y][z] = {0};
        int q = 0;
        bool[,,] position = new bool[5,8,5];
        GameObject cube(q) = GameObject.FindWithTag("cube");
        int count = 0;
        for (int x = 0; x < 5; x++)
        {
            for (int z = 0; z < 5; z++)
            {
                for (int y = 0; y < 8; y++)
                {
                    //count == ?|| ?는 큐브 넘버 ???
                  
                    if (position[x][y][z] == true & count == 1)
                    {
                            
                     //show 명령어
                     cube(q).SetActive(true);
                     // x, y, z 위치로 이동 명령어
                     cube(q).transform.postion = new Vector3(x, z, y);
                        q = q + 1;
                            //걍 instantiate 로 만들면 안되나
                            
                    }
                    
                }
            }
        }
    }
}