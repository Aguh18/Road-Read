using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignSpawner : MonoBehaviour
{
    Sprite[] sprites;
    int batastanda;

    public Sprite getRandomSprite(){
        int rand = UnityEngine.Random.Range(0, batastanda - 1);

        return sprites[rand];
    }
}
