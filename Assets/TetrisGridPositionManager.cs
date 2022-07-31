using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisGridPositionManager : MonoBehaviour
{
    [SerializeField]
    private GameObject cubeprefab;

    // Start is called before the first frame update
    void Start()
    {
        //hide 명령어
    }

    // Update is called once per frame
    void Update()
    {
        // 배열 오브젝트끼리 공유 하 기
        //temporary array would defined: bool positionarray[x][y][z] = {0};
        
        int count = 0;
        for(int x = 0; x<5; x++)
        {
            for(int z = 0; z < 5; z++)
            {
                for(int y = 0; y < 8; y++)
                {
                    if (positionarray[x][y][z] == 1)
                    {
                        this.AddGameObject(x, y, z, count);
                    }
                }
            }
        }
    }
    public void AddGameObject(int x, int y, int z, int count)
    {
        GameObject Prefab = new GameObject("Name" + count);
        Vector3 objectPOS = new Vector3(x, y, z);
        GameObject newGameObject = Instantiate(Prefab, objectPOS, Quaternion.identity);
    }
}