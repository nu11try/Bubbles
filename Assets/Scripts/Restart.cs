using UnityEngine.SceneManagement;
using UnityEngine;

public class Restart : MonoBehaviour
{
    void OnMouseDown () {
        switch (gameObject.name) {
		case "Rest":
			SceneManager.LoadScene ("lvl1");
			break;

		case "Rest2":
			SceneManager.LoadScene ("lvl2");
			break;
		}
    }
}
