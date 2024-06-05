using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burger : MonoBehaviour
{
    [SerializeField] private float despawnDelay = 1f;
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Floor"))
        {
            Debug.Log("Whoopsie, I collided with the floor!");
            StartCoroutine(DespawnAfterDelay(despawnDelay)); // Despawn after 3 seconds
        }
        if (collision.gameObject.CompareTag("Food"))
        {
            Debug.Log("Whoopsie, I collided with another burger, ew!");
        }
    }

    IEnumerator DespawnAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }
}

/**
New knowledge acquired: By doing Destroy(gameObject), we are destroying the game object this script is attached to,
in this case the burger. If instead we do Destroy(this), we destroy just this script, but we keep the burger!
This makes it so that all the functionality and everything else that came with this script just POOF, vanishes!
Here is an idea of an interesting use-case scenario, think of a gargoyle enemy in a game, for example, that moves around,
attacks you, can be killed etc., but when the sun rises, it trigers something that makes it "destroy" certain components
and script, leaving it there, but removing some functionality, practically "turning it to stone". How cool is that?!?!
**/

/**
Questions:
- Can I somehow make it that when a burger collides, it tells that to the FoodDropper so that it spawns another one?
Semms like it would be useful, but I have done enough work for today and it's late, so I'll search for this answer
tomorrow.
**/