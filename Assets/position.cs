using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //hide 명령어
    }

    // Update is called once per frame
    void Update()
    {
        // 배열 오브젝트끼리 공유 하 기
        //temporary array would defined: bool position[x][y][z] = {0};

        int count = 0;
        for (int x = 0; x < 5; x++)
        {
            for (int z = 0; z < 5; z++)
            {
                for (int y = 0; y < 8; y++)
                {
                    //count == ?|| ?는 큐브 넘버
                    if (position[x][y][z] == 1 & count == 1)
                    {
                        //show 명령어
                        // x, y, z 위치로 이동 명령어
                    }
                }
            }
        }
    }
}