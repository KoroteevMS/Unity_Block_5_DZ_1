using UnityEngine;

public class Increase : SpeedInfo
{
    [SerializeField] private float _scaleStep = 0.1f;

    private void Update()
    {
        float scaleChange = _scaleStep * Speed;
        transform.localScale += new Vector3(scaleChange, scaleChange, scaleChange);
    }
}