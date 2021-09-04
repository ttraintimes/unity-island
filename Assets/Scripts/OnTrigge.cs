using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigge : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<GameManamge>().a2 = 1;
        gameObject.SetActive(false);

    }
}
