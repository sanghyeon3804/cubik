using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //hide ��ɾ�
    }

    // Update is called once per frame
    void Update()
    {
        // �迭 ������Ʈ���� ���� �� ��
        //temporary array would defined: bool position[x][y][z] = {0};

        int count = 0;
        for (int x = 0; x < 5; x++)
        {
            for (int z = 0; z < 5; z++)
            {
                for (int y = 0; y < 8; y++)
                {
                    //count == ?|| ?�� ť�� �ѹ�
                    if (position[x][y][z] == 1 & count == 1)
                    {
                        //show ��ɾ�
                        // x, y, z ��ġ�� �̵� ��ɾ�
                    }
                }
            }
        }
    }
}