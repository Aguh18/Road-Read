using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    #region singleton
    public static QuizManager Instance;
    private void Awake() {
        if(Instance == null){
            Instance = this;
        }
    }
    #endregion


    int indexjawabanbenar;
    public String[] jawaban;
    [SerializeField] int[] jawabanbutton;

    public Transform quizPanel;

    
    public void setJawabanBenar(int x){
        indexjawabanbenar = x;
    }

    public void GenerateQuiz(){
        quizPanel.gameObject.SetActive(true);
        jawabanbutton[UnityEngine.Random.Range(0, 2)] = indexjawabanbenar;

        for(int i = 0; i < quizPanel.childCount; i++){
            Transform button = quizPanel.GetChild(i);
            if(jawabanbutton[i] != -1){
                button.GetChild(0).GetComponent<Text>().text = jawaban[indexjawabanbenar];
                continue;
            }

            jawabanbutton[i] = UnityEngine.Random.Range(0, jawaban.Length);
            button.GetChild(0).GetComponent<Text>().text = jawaban[jawabanbutton[i]];

        }
    }

    public void buttonclick(int idx){
        if(indexjawabanbenar == jawabanbutton[idx]){
            Debug.Log("Jawaban anda benar");
            quizPanel.gameObject.SetActive(false);
            indexjawabanbenar = -1;
        }
        else{
            Debug.Log("tidak benar");
            quizPanel.gameObject.SetActive(false);
            indexjawabanbenar = -1;
        }
    }
}
