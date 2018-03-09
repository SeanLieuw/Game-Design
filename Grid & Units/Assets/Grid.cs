using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Grid : MonoBehaviour
{

    // Use this for initialization
    public Tile prefab;
    // Use this for initialization
    public Unit prefab2;
    void Start()
    {
        for (int x = 0; x < 9; x++)
        {
            for (int y = 0; y < 9; y++)
            {
                Instantiate(prefab, new Vector3(x * 1, 0, y * 1), Quaternion.identity);
            }

        }
        for (int x = 0; x < 9; x++)
        {
            for (int y = 0; y < 9; y++)
            {
                Instantiate(prefab2, new Vector3(x * 1, 0, y * 1), Quaternion.identity);
                y++;
            }
            x++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}