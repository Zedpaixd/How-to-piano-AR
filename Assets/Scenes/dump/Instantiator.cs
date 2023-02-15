using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject thingtospawn;

    private void Awake()
    {
        thingtospawn.SetActive(true);
    }
}
