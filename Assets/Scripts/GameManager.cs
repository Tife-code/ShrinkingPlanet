using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	public GameObject gameOverUI, controlsUI;

	int frameCount = 0;
	float dt = 0.0f;
	float FPS;
	float updateRate = 4.0f;
	public TextMeshProUGUI FPS_text;



	void Awake ()
	{
		instance = this;
		FPS_text.text = "FPS = ";

	}

	private void Update()
    {
		frameCount++;
		dt += Time.deltaTime;
		if (dt > 1.0 / updateRate)
        {
			FPS = frameCount / dt;
			frameCount = 0;
			dt -= 1.0f / updateRate; 
        }
		FPS_text.text = "FPS = " + Mathf.Round(FPS).ToString();
    }

    public void EndGame ()
	{
		gameOverUI.SetActive(true);
		controlsUI.SetActive(false);
	}

	public void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

}
