using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //hide ��ɾ�
        //����� ��Ȱ��ȭ
        GameObject obj0 = GameObject.Find("shape_cube");  //����� = obj ���߿� �±׷� �ϰų� �밡��
        Vector3 pos;
        pos = obj0.GameObject.transform.position;

        while (true) //�̷��� �� ������ ���� ���ѹݺ��� �ǳ�
        {
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    for (int r = 0; r < 8; r++)
                    {

                        if (pos.x == i && pos.z == k && pos.y == r)
                        {
                            obj0.SetActive(false);
                            int i = 0;
                            int k = 0;
                            int r = 0;
                        }
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
                  
                    if (position[x][z][y] == true)
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

    //�������� ��ü 

    //������ ��ü




}