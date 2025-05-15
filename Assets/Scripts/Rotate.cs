using UnityEngine;

public class Rotate : SpeedInfo
{
    private void Update()
    {
        transform.Rotate(Vector3.up, Speed);
    }
}