using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curves : MonoBehaviour
{
    private static Curves _instance;

    public static Curves Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
            Destroy(this.gameObject);
        else
            _instance = this;
    }

    public float Linear(Vector3 input)
    {
        return (input.x + input.z) / 2;
    }

    public float Exponential(Vector3 input)
    {
        return Mathf.Pow(input.x, input.z);
    }

    public float Exponential(Vector3 input, float maxRange, float upperRange)
    {
        float higher = input.x > input.z ? input.x : input.z;
        return maxRange * (Mathf.Pow(higher, 2) / Mathf.Pow(upperRange, 2));
    }
}
