using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int sizeX;
    [SerializeField] int sizeZ;
    [SerializeField] GameObject tile;

    // Start is called before the first frame update
    void Start() {
        CreateTable(sizeX, sizeZ);
    }

    // Update is called once per frame
    void Update() {
        
    }

    void CreateTable(int sX, int sZ) {
        for(int i = 0; i < sX; i++)
        {
            for (int j = 0; j < sZ; j++) {
                float posX = ((sX - 1f) / 2f) - i;
                float posZ = ((sZ - 1f) / 2f) - j;
                Vector3 pos = new Vector3(posX, 0, posZ);

                GameObject tileInGame = Instantiate(tile, pos, Quaternion.identity, this.transform);

                if ((i % 2 == 0 && j % 2 == 0) || (i % 2 == 1 && j % 2 == 1)) {
                    tileInGame.GetComponent<MeshRenderer>().material.color = new Color(0,0,0);
                }
                else {
                    tileInGame.GetComponent<MeshRenderer>().material.color = new Color(1,1,1);
                }
            }
        }
    }
}
