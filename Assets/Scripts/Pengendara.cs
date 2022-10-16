using System;
using UnityEngine;
using UnityEngine.UI;

public class Pengendara : MonoBehaviour
{
    private int nyawa;
    public float kecepatan;
    public float jarakTempuh;
    [SerializeField] private bool isDead;
    


    //UI meter
    public Text jarakUI;

    private void Start() {
        nyawa = 4;
        kecepatan = 7;
    }

    void Update(){
        if(!IsDead()){
            jarakTempuh += kecepatan * Time.deltaTime;
            jarakUI.text = String.Format("{0:00}", jarakTempuh) + " Meter";
        }

        if(kecepatan > 7){
            transform.Translate(Vector2.right * (kecepatan - 7) * Time.deltaTime);

        }
        if(kecepatan == 7){
            transform.Translate(Vector2. left * 1 * Time.deltaTime);
            if(transform.position.x <= -6.5){
                transform.position = new Vector2(-6.5f, transform.position.y);
            }
        }
    }

    public void nyawaBerkurang(){
        if(nyawa < 0){
            Dead();
        }
        nyawa--;
    }

    void Dead(){

    }


    public bool IsDead(){
        return isDead;
    }
}
