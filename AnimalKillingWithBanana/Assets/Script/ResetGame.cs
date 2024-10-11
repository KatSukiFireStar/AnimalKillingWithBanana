using UnityEngine;

public class ResetGame : MonoBehaviour
{
	[SerializeField]
	private Transform spawnner;
	[SerializeField] 
	private GestionnaireJeu gestionnaireJeu;
	[SerializeField] 
	private ControleJoueur controleJoueur;
	[SerializeField] 
	private LifeCounter lifeCounter;
	
	public void Restart()
	{
		gestionnaireJeu.gameOver = false;
		gestionnaireJeu.scoreCounter.score = 0;
		controleJoueur.gameOver = false;
		lifeCounter.Restart();
	}

	public void Quit()
	{
#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
	}
}