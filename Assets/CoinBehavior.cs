using UnityEngine;
using UnityEngine.UI;

public class CoinBehavior : MonoBehaviour {
	private GameObject _gameLogic;
	private int outOfGameThresholdY = -2;

	void Start() {
		_gameLogic = GameObject.Find("Initializer");
	}

	// Update is called once per frame
	void Update() {
		if (transform.position.y < outOfGameThresholdY) {
			_gameLogic.SendMessage("IncreaseScore");
			Destroy(gameObject);
		}
	}
}