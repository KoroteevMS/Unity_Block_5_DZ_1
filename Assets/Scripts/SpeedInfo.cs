using UnityEngine;

public class SpeedInfo : MonoBehaviour
{
    [SerializeField] private float _speed;

    protected float Speed => _speed * Time.deltaTime;
}