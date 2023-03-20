using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
  public int playerScore = 0;
  public Text scoreText;
  public GameObject gameOverPanel;

  public void updateScore(int scoreToAdd)
  {
    playerScore += scoreToAdd;
    scoreText.text = playerScore.ToString();
  }

  public void gameOver()
  {
    gameOverPanel.SetActive(true);
  }

  public void restartGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}
