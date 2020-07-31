using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPermanent : MonoBehaviour
{
    [SerializeField] 
    private Vector3 RotationSpeed = new Vector3(30, 30, 30);
    void Update()
    {
        transform.Rotate(RotationSpeed * Time.deltaTime);
    }
}
