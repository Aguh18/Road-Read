using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MoveLeft
{
    [SerializeField] Sprite sprite;

    private void Update() {
        Move();
    }
}
