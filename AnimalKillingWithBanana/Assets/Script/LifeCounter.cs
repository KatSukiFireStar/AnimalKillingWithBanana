using System;
using UnityEngine;

public class LifeCounter : MonoBehaviour
{
	[SerializeField]
	private GameObject menu;
	
	[SerializeField]
	private GestionnaireJeu gestionnaireJeu;
	[SerializeField] 
	private ControleJoueur controleJoueur;

	[HideInInspector]
	public int life = 3;
	
	private void Update()
	{
		if (life <= 0)
		{
			EndGame();
		}
	}

	private void EndGame()
	{
		gestionnaireJeu.gameOver = true;
		controleJoueur.gameOver = true;
		menu.SetActive(true);
	}

	public void Restart()
	{
		life = 3;
		foreach (Transform child in transform)
		{
			child.gameObject.SetActive(true);
		}
		menu.SetActive(false);
	}
}