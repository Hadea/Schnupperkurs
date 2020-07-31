using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    private float PlayerForwardSpeed;
    [SerializeField]
    private float PlayerRotationSpeed;

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * PlayerForwardSpeed* Time.fixedDeltaTime * Input.GetAxis("Vertical"));
        transform.Rotate(Vector3.up * PlayerRotationSpeed * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger wurde ausgelöst, raumschiff wird zerstört");
        Camera.main.transform.parent = null;
        Destroy(this.gameObject);
    }

}
