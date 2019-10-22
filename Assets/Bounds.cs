using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<Ball>().Respawn();
        FindObjectOfType<BrickManager>().ResetLevel();
    }
}
