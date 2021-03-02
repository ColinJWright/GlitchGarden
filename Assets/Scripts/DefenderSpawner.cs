using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defenderPrefab;

    private void OnMouseDown()
    {
        SpawnDefender();
    }

    private void SpawnDefender()
    {
        GameObject newDefender =  Instantiate(defenderPrefab, transform.position, Quaternion.identity) as GameObject;
    }
}
