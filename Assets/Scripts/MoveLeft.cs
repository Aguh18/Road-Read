using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] int kecepatan;
    public Pengendara pengendara;

    public void Move(){
        if(!pengendara.IsDead()){
            transform.Translate(Vector3.left * kecepatan * Time.deltaTime);
        }
    }
}
