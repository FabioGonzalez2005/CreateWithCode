using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;

    void Start() {
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
    }
        
    IEnumerator SpawnTarget() {
        while (true) { 
            // Código omitido para el spawn
            UpdateScore(5); 
            yield return new WaitForSeconds(1); // Ejemplo de espera
        }
    }

    public void UpdateScore(int scoreToAdd) {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    void Update() {
        // Este método no hace nada, pero es parte de la clase
    }
}
