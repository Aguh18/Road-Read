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
        jawabanbutton[UnityEngine.Random.Range(0, 2)] = indexjawabanbenar;

        for(int i = 0; i < quizPanel.childCount; i++){
            if(jawabanbutton[i] != -1){
                Transform button = quizPanel.GetChild(i);
                button.GetChild(0).GetComponent<Text>().text = jawaban[indexjawabanbenar];
            }
        }
    }

    public void buttonclick(int idx){
        if(indexjawabanbenar == jawabanbutton[idx]){

        }
    }
}
