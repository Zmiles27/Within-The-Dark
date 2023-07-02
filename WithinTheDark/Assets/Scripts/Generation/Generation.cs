using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{
    private Texture2D noiseTex;
    private Color[] pix;
    private Renderer rend;

    public List<GameObject> GrassTiles;
    public List<GameObject> SandTiles;

    public int spawnLength = 100;

    public Transform parent;
    void Start()
    {
        rend = GetComponent<Renderer>();

        TileRandomizer();
    }
    void Update()
    {
      
    }

    // Randomizes Tiles
    void TileRandomizer()
    {
        var random = new System.Random();        

        int index = random.Next(GrassTiles.Count);
        for (int x = 0; x < spawnLength * 10; x = x + 10)
        {
            for (int z = 0; z < spawnLength * 10; z = z + 10)
            {
                Instantiate(GrassTiles[UnityEngine.Random.Range(0, 8)], new Vector3(x , 0, z), Quaternion.identity, parent);
            }
        }
    }
}
