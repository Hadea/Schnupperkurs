using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundPermanent : MonoBehaviour
{
    [SerializeField]
    private GameObject ZielObjekt;
    [SerializeField]
    private float RotationsTempo;
    void Update()
    {
        transform.RotateAround(ZielObjekt.transform.position, Vector3.up, RotationsTempo * Time.deltaTime);
    }
}
