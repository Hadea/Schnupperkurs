using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    private float PlayerForwardSpeed;
    [SerializeField]
    private float PlayerRotationSpeed;

    void Update()
    {
        transform.Translate(Vector3.forward * PlayerForwardSpeed* Time.deltaTime * Input.GetAxis("Vertical"));
        transform.Rotate(Vector3.up * PlayerRotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger wurde ausgelöst, raumsich wird zerstört");
        Camera.main.transform.parent = null;
        Destroy(this.gameObject);
    }

}
