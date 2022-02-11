using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 0;

    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        //_rigidbody.AddForce(new Vector2 (x * _speed, 0));
        //Debug.Log(x);
        _rigidbody.velocity = new Vector3(x * _speed, 0);

    }
}
