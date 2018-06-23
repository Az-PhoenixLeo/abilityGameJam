using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
using UnityEngine.SceneManagement;

//ADMINISTRADOR DE DIALOGO
//se encarga de activar o desactivar el cuadro de texto
//segun condicion de activacion y tecleo

public class DialogueManager : MonoBehaviour {

	//variable de caja de texto
	public GameObject dBox;
	//variable de texto
	public Text dText;
	public Text dText1;
	public Text dText2;
	public Text dText3;
	public Text dTextFinal;
	private bool dialogueActivated;
	private string dialogue;
	private string dialogue1;
	private string dialogue2;
	private string dialogue3;
	private string[] dialogueLine;
	private string[] dialogueLine1;
	private string[] dialogueLine2;
	private string[] dialogueLine3;
	private MobileUICtrl mob;
	//private Player player;
	public GameObject buttonUp;
	public GameObject buttonLeft;
	public GameObject buttonRight;
	private int contadorDialogo;
	private int score;
	public int limitecontador;
	public int lim1;
	public int lim2;
	public GameObject final;
	//Camera cam = Camera.main;


	void Start () {
		//Debug.Log (cam.orthographicSize * 2f);
		//Debug.Log ((cam.orthographicSize * 2) * cam.aspect);

		mob = FindObjectOfType<MobileUICtrl> ();

		dialogueLine = File.ReadAllLines ("file.txt", Encoding.Default);
		dialogueLine1 = File.ReadAllLines ("fileUNO.txt",Encoding.Default);
		dialogueLine2 = File.ReadAllLines ("fileDOS.txt",Encoding.Default);
		dialogueLine3 = File.ReadAllLines ("fileTRES.txt",Encoding.Default);
		setActualDialogue (1);
		score = 0;
		contadorDialogo = 1;
		final.SetActive (false);
		buttonUp.SetActive (true);
		buttonLeft.SetActive (true);
		buttonRight.SetActive (true);	
	}

	void Update () {

		if (contadorDialogo >= limitecontador) {
			final.SetActive (true);
			buttonUp.SetActive (false);
			buttonLeft.SetActive (false);
			buttonRight.SetActive (false);

			if (score >= 0 && score < lim1) 
			{
				dTextFinal.text = "Eres muy tolerante";
			}
			if (score >= lim1 && score < lim2) 
			{
				dTextFinal.text = "Eres medio tolerante";
			}
			if (score >= lim2) 
			{
				dTextFinal.text = "Eres un INtolerante";
			}
		}

		setActualDialogue (contadorDialogo);
		getActualDialogue ();
		dText.text = getActualDialogue();
		dText1.text = getActualDialogue1();
		dText2.text = getActualDialogue2();
		dText3.text = getActualDialogue3();


	}

	public void opcionUno()
	{
		score = score + 1;
		contadorDialogo++;
	}

	public void opcionDos()
	{
		score = score + 2;
		contadorDialogo++;
	}

	public void opcionTres()
	{
		score = score + 3;
		contadorDialogo++;
	}

	public void reset()
	{
		SceneManager.LoadScene("CambioDeVida");
	}


	public void setActualDialogue(int idDialogo)
	{
		dialogue = dialogueLine[idDialogo-1]; 
		dialogue1 = dialogueLine1[idDialogo-1]; 
		dialogue2 = dialogueLine2[idDialogo-1]; 
		dialogue3 = dialogueLine3[idDialogo-1];
	}

	public string getActualDialogue()
	{
		return dialogue; 
	}

	public string getActualDialogue1()
	{
		return dialogue1;
	}
	public string getActualDialogue2()
	{
		return dialogue2;
	}
	public string getActualDialogue3()
	{
		return dialogue3;
	}




}
