using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float spawnRate = 1.0f;
    public List<GameObject> targets;
    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    void Start()
    {
        isGameActive = true;

        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
        
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);

        isGameActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score:" + score;
    }
    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);

        }
    
    }

    void Update()
    {
        
    }
}
