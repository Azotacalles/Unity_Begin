using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 direction;

    // Update is called once per frame
    private void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        var newSpeed = direction * speed * Time.fixedDeltaTime;
        transform.Translate(newSpeed);
    }
}
