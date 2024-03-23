using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectsRandomly : MonoBehaviour
{

    [SerializeField] List<GameObject> donuts;
    [SerializeField] List<GameObject> aliens;
    void Start()
    {
        SpawnDonuts();
        SpawnAliens();
    }

    void SpawnDonuts()
    {

        for (int i = 0; i < donuts.Count; i++)
        {
            Vector2 position = Camera.main.ViewportToWorldPoint(new Vector2(Random.value, Random.value));
            Instantiate(donuts[i], position, Quaternion.identity);

        }
    }

    void SpawnAliens()
    {

        for (int i = 0; i < aliens.Count; i++)
        {
            Vector2 position = Camera.main.ViewportToWorldPoint(new Vector2(Random.value, Random.value));
            Instantiate(aliens[i], position, Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Donut") || other.gameObject.CompareTag("Alien"))
        {
            Destroy(other.gameObject);
        }
    }
}
