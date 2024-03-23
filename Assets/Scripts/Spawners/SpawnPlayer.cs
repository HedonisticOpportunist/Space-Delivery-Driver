using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] GameObject player;
    void Start()
    {
        SpawnPlayerRandomly();
    }

    void SpawnPlayerRandomly()
    {
        Vector2 position = Camera.main.ViewportToWorldPoint(new Vector2(Random.value, Random.value));
        Instantiate(player, position, Quaternion.identity);
    }
}
