 cdusing System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //hide ��ɾ�
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
        // �迭 ������Ʈ���� ���� �� ��
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
                    //count == ?|| ?�� ť�� �ѹ� ???
                  
                    if (position[x][y][z] == true & count == 1)
                    {
                            
                     //show ��ɾ�
                     cube(q).SetActive(true);
                     // x, y, z ��ġ�� �̵� ��ɾ�
                     cube(q).transform.postion = new Vector3(x, z, y);
                        q = q + 1;
                            //�� instantiate �� ����� �ȵǳ�
                            
                    }
                    
                }
            }
        }
    }
}