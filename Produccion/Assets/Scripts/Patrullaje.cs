using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrullaje : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointIndex = 0;

    [SerializeField] private float speed;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);

        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .2f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
    }
}
