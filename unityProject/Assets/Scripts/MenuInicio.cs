using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuInicio : MonoBehaviour {
    AudioClip audiofile;
    public GameObject boton1;
    void Start () {
        StartCoroutine(Audiointro());
    }
    IEnumerator Audiointro()
    {
       /* audiofile = Resources.Load("LifeHasChanged") as AudioClip;
        this.gameObject.GetComponent<AudioSource>().PlayOneShot(audiofile);*/
        yield return new WaitForSecondsRealtime(0);
        boton1.GetComponent<Button>().Select();
    }
    public void Iniciar()
    {
        SceneManager.LoadScene("CambioDeVida", LoadSceneMode.Single);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
