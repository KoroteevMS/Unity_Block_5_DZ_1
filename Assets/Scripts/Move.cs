using UnityEngine;

public class Move : SpeedInfo
{
    private void Update()
    {
        transform.Translate(Speed * Vector3.forward);
    }
}