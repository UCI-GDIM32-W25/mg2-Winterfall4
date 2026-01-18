using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _playerRigidbody;
    [SerializeField] private TMP_Text _pointText;

    private int points;
    private bool onGround;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onGround == true)
            {
                _playerRigidbody.velocity = new Vector2(
                _playerRigidbody.velocity.x,
                6.0f
                );
            }
        }
    }

    private void OnTriggerEnter2D (Collider2D collider)
    {
        Destroy(collider.gameObject);
        points++;
        _pointText.text = points.ToString();
    }

    private void OnCollisionStay2D()
    {
        onGround = true;
    }

    private void OnCollisionExit2D()
    {
        onGround = false;
    }


}
