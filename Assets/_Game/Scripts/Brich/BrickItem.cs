using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickItem : MonoBehaviour
{
    [SerializeField] private bool canAdd;

    private void Start()
    {
        canAdd = true;
    }
}
