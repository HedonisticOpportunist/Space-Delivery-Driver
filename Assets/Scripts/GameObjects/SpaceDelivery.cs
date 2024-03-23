using UnityEngine;

public class SpaceDelivery : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Donut") && !hasPackage)
        {
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.CompareTag("Alien") && hasPackage)
        {
            hasPackage = false;
            Destroy(other.gameObject, destroyDelay);
        }

    }
}
