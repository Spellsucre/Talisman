using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {


	public class Region
	{

		string nom; //Nom de la region courante
		public enum TailleRegion {Petite, Moyenne, Grande, Gigantesque,  Custom}
		TailleRegion tailleRegion; // Taille de la region
		int largeur, hauteur; //Largeur et Hauteur de la region actuelle
		List<regionLayers> layers; //Liste des layers de la region

		public string GetNom { get { return name; } } //Get le nom de la region
		public TailleRegion GetTailleRegion { get { return tailleRegion; } } //Get la taille de la region actuelle (enum)
		public int GetHauteur { get { return hauteur; } } //Get la hauteur de la region actuelle
		public int GetLargeur { get { return largeur; } } //Get la largeur de la region actuelle
		public int GetNombreLayer { get { return layers.Count; } } // Get le nombre de layers de la region actuelle

		public Region() {} //Constructeur par defaut de la classe region


		/// <summary>
		/// Constructeur surchargé pour la classe region utilisant une taille pré-définie.
		/// </summary>
		/// <param name="nom">Nom de cette region.</param>
		/// <param name="TailleRegion">Taille de la region parmi:"Petite, Moyenne, Grande, Gigantesque".</param>	
		public Region(string nom, TailleRegion tailleRegion) 
		{
			this.nom = nom;
			this.tailleRegion = tailleRegion;

			MeasureWorld(GetTailleRegion);
			
		}

		/// <summary>
		/// Constructeur surchargé pour la classe region
		/// </summary>
		/// <param name="nom">Nom de cette region.</param>
		/// <param name="TailleRegion">Taille de la region parmi:"Petite, Moyenne, Grande, Gigantesque".</param>	
		public Region(string nom, TailleRegion tailleRegion) 

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () { } 
		
	}
}
