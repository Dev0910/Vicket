using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float life = 5f;

    void Awake()
    {
        Destroy(gameObject, life);
    }
}