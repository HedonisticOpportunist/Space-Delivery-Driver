using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;
    Vector2 minimumBounds;
    Vector2 maximumBounds;


    void Start()
    {
        InitBounds();
    }

    void Update()
    {
        MoveSpaceCraft();
    }

    void MoveSpaceCraft()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);

        Vector2 newPos = new()
        {
            x = Mathf.Clamp(transform.position.x, minimumBounds.x, maximumBounds.x),
            y = Mathf.Clamp(transform.position.y, minimumBounds.y, maximumBounds.y)
        };
        transform.position = newPos;

    }

    void InitBounds()
    {
        Camera mainCamera = Camera.main;
        minimumBounds = mainCamera.ViewportToWorldPoint(new Vector2(0, 0));
        maximumBounds = mainCamera.ViewportToWorldPoint(new Vector2(1, 1));
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;
    }
}
