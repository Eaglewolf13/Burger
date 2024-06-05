using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FoodDropper : MonoBehaviour
{

    [SerializeField] private Vector3 startingPosition = new Vector3(-3, 3, 0);
    [SerializeField] private Vector3 endingPosition;
    [SerializeField] private Vector3 positionOffset = new Vector3(6, 0, 0);
    [SerializeField] private GameObject foodToSpawn;
    void Start()
    {
         transform.position = startingPosition;
         endingPosition = startingPosition + positionOffset;
         InvokeRepeating("SpawnFoodRandomly", 0f, 2f);
    }

    void Update()
    {
        
    }

    void SpawnFoodRandomly()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(startingPosition.x, endingPosition.x),
                                            Random.Range(startingPosition.y, endingPosition.y),
                                            Random.Range(startingPosition.z, endingPosition.z));
        Debug.Log("The coordinates of the spawn are: " + spawnPosition.x + " " + spawnPosition.y + " " + spawnPosition.z);
        Instantiate(foodToSpawn, spawnPosition, Quaternion.identity);
        
    }

}

/**
New knowledge:
- If we change something in the defined values in the script itself, it won't be changed for objects that already
have it attached in unity. And I think the other way around won't change anything here either.
- When adding a script to an object, we can click "Add Component" and search for the name of the script, but we
can also simply drag and drop the script there!
- We can apply a material to an object by dragging the material to the object in the scene. For some reason it
doesn't work if you add it to its material component in the editor.
**/