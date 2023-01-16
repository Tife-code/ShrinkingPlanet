using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Text))]
public class FinalScoreUI : MonoBehaviour {

	void Start ()
	{
		GetComponent<Text>().text = "d = <i><b>" + Mathf.Round(Planet.Score).ToString("")  + "</b>m</i>";
	}
	 
}
