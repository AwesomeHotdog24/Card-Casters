using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{    
    void Spawn(Object spawnObject, Vector3 positionToSpawn)
    {
        Instantiate(spawnObject,positionToSpawn, Quaternion.identity);
    }
}
