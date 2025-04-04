using UnityEngine;
using System.Collections;
using TMPro;

public class Player : MonoBehaviour {
    public class ScoreManager : MonoBehaviour
    {
        public static int score = 0; // Puntuación global
        public TextMeshProUGUI scoreText; // Referencia al texto que mostrará la puntuación

        // Método para añadir puntos al puntaje
        public void AddScore(int points)
        {
            score += points;
            UpdateScoreUI();
        }

        // Método para actualizar el texto del score en la UI
        void UpdateScoreUI()
        {
            if (scoreText != null)
            {
                scoreText.text = "Puntuación: " + score; // Muestra la puntuación en el texto UI
            }
        }

        // Método para reiniciar la puntuación (si es necesario)
        public void ResetScore()
        {
            score = 0;
            UpdateScoreUI();
        }
    }

    public bool canPick = false;

	public bool picked = false;
	public bool won = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (canPick == true) {

            //if (/*GvrViewer.Instance.Triggered ||*/ Input.GetKeyDown ("space")) {
            RaycastHit hit;


				if (Physics.Raycast(transform.position, transform.forward, out hit)) {

					Cup cup = hit.transform.GetComponent<Cup> ();
					if (cup != null) {
						canPick = false;

						picked = true;
						won = (cup.ball != null);

						cup.MoveUp ();
					}

				}
            //	}

        }
    }
}
