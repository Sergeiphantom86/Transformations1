using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void FixedUpdate()
    {
        transform.localScale += transform.lossyScale * _speed;
    }
}