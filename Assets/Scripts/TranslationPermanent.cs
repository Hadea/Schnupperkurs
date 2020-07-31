using UnityEngine;

public class TranslationPermanent : MonoBehaviour
{
    [SerializeField]
    private Vector3 MoveSpeed = Vector3.zero;
    void Update()
    {
        transform.Translate(MoveSpeed * Time.deltaTime, Space.World);
    }
}
