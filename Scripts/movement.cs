using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float horSpeed;
    float hor;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(hor * horSpeed * Time.deltaTime, 0, movementSpeed * Time.deltaTime));
    }
}
