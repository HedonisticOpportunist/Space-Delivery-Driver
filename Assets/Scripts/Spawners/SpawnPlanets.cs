using System.Collections.Generic;
using UnityEngine;

public class SpawnPlanets : MonoBehaviour
{

    [SerializeField] List<GameObject> planets;
    void Start()
    {
        SpawnPlanetsRandomly();
    }

   void SpawnPlanetsRandomly()
    {

        for (int i = 0; i < planets.Count; i++)
        {
            Vector2 position = Camera.main.ViewportToWorldPoint(new Vector2(Random.value, Random.value));
            Instantiate(planets[i], position, Quaternion.identity);
              
        }
    }
}
