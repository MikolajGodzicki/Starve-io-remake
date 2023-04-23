using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMobSpawner : MonoBehaviour
{
    [Header("World Size Configuration:")]
    [SerializeField]
    private int WorldWidth;
    [SerializeField]
    private int WorldHeight;

    private int worldWidthSpawnSize;
    private int worldHeightSpawnSize;

    [SerializeField]
    private GameObject[] mobs;

    private void Start() {
        worldWidthSpawnSize = WorldWidth / 2;
        worldHeightSpawnSize = WorldHeight / 2;
    }

    public void SpawnMobs() {

    }
}
