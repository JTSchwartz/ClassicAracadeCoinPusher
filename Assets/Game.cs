using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {
	public GameObject coinPrefab;
	public Slider playerControls;
	public Text scoreBoard;
	private const int CoinCount = 750;
	private int _score = 0;

	void IncreaseScore() {
		scoreBoard.text = "Score: " + ++_score;
	}

	void Start() {
		scoreBoard.text = "Score: 0";

		for (int i = 0; i < CoinCount; i++) {
			Instantiate(coinPrefab,
						new Vector3(Random.Range(-9.5f, 9.5f), 5, Random.Range(-4.5f, 5.5f)),
						Quaternion.Euler(new Vector3(0, 0, 0)));
		}
	}

	// Update is called once per frame
	void Update() {
		if (Input.GetKeyDown(KeyCode.Space)) {
			Instantiate(coinPrefab, new Vector3(playerControls.value, 5, 3.5f), Quaternion.Euler(new Vector3(0, 0, 0)));
		}
	}
}