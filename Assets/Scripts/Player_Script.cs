using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _playerRigidbody;
    [SerializeField] private CapsuleCollider2D _playerCollider;



    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerRigidbody.velocity = new Vector2(
                _playerRigidbody.velocity.x,
                6.0f
                );
            
        }
    }

    private void OnTriggerEnter2D (Collider2D collider)
    {
        Debug.Log("Coin Hit!");
        Destroy(collider.gameObject);
    }


}
