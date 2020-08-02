using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
	[SerializeField] private Text scoreText = null;

	void Update()
	{
		int score = GameManager.I.Score;
		scoreText.text = $"Score: {score.ToString()}";
	}
}
