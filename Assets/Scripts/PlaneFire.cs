using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneFire : MonoBehaviour
{
    public GameObject missilePrefab;
    public Transform missileSpawnPoint1;
    public Transform missileSpawnPoint2;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FireMissile();
        }
    }

    void FireMissile()
    {
        Instantiate(missilePrefab, missileSpawnPoint1.position,transform.rotation);
        Instantiate(missilePrefab, missileSpawnPoint2.position,transform.rotation);
    }
}