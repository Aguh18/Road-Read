using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignSpawner : MonoBehaviour
{
    [SerializeField] Sprite[] sprites;
    public int batastanda;
    [SerializeField] Pengendara pengendara;
    public Sign signRef;


    private void Start() {
        StartCoroutine(SpawnSign());
    }
    public Sprite getRandomSprite(){
        int rand = UnityEngine.Random.Range(0, batastanda - 1);

        return sprites[rand];
    }

    IEnumerator SpawnSign(){
        while(true){
            Sign newSign = Instantiate(signRef);
            newSign.gameObject.SetActive(true);
            QuizManager.Instance.GenerateQuiz();
            yield return new WaitForSeconds(5f);


        }

    }
}
