using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(WorldMobSpawner))]
public class WorldGenerator : MonoBehaviour
{
    [Header("World Size Configuration:")]
    [SerializeField]
    private int WorldWidth;
    [SerializeField]
    private int WorldHeight;

    private int worldWidthSpawnSize;
    private int worldHeightSpawnSize;

    [Header("Entities:")]
    [SerializeField]
    private GameObject[] rocks;

    [SerializeField]
    private GameObject[] trees;

    [SerializeField]
    private GameObject[] grass;

    [SerializeField]
    private GameObject[] berries;

    private WorldMobSpawner mobSpawner;

    

    private void Start() {
        mobSpawner = GetComponent<WorldMobSpawner>();

        worldWidthSpawnSize = WorldWidth / 2;
        worldHeightSpawnSize = WorldHeight / 2;
    }
}
