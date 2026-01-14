using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer_Script : MonoBehaviour
{

    [SerializeField] private BoxCollider2D _destroyerCollider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Coin Hit!");
        Destroy(collider.gameObject);
    }
}
