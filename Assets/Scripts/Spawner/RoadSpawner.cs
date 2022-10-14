using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    public Transform env;
    public Road prevRoad, roadRef;

    void Spawn(){
        Road newroad = Instantiate(roadRef);
        newroad.gameObject.SetActive(true);
        prevRoad.SetNextPos(newroad);
    }
    private void OnTriggerExit2D(Collider2D other) {
        Road road = other.GetComponent<Road>();
        road.transform.SetParent(env);

        if(road){
            prevRoad = road;

            Spawn();
        }
    }
}
