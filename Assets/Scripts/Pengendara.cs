using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pengendara : MonoBehaviour
{
    public int nyawa;
    public float jarakTempuh;
    [SerializeField] private bool isDead;

    private void Start() {
        
    }

    private void Update() {
        
    }

    public bool IsDead(){
        return isDead;
    }
}
