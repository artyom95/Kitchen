using UnityEngine;

/// <summary>
/// Выпрыгивающая из тостера вафля
/// </summary>
public class Waffle : MonoBehaviour
{
    private void Awake()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(Vector3.up * 100f);
    }
}