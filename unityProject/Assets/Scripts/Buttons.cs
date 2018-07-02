using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour {
    public GameObject boton1;
    GameObject seleccionado;
    public static bool listo;
    AudioClip audiofile;
    void Start() {
        listo = false;
        StartCoroutine(Audiointro());
    }
    IEnumerator Audiointro()
    {
        audiofile= Resources.Load("narrador_entrada") as AudioClip;
        this.gameObject.GetComponent<AudioSource>().PlayOneShot(audiofile);
        yield return new WaitForSecondsRealtime(audiofile.length);
        audiofile = Resources.Load("Jorge/preludio") as AudioClip;
        this.gameObject.GetComponent<AudioSource>().PlayOneShot(audiofile);
        yield return new WaitForSecondsRealtime(audiofile.length); audiofile = Resources.Load("narrador_1dia") as AudioClip;
        this.gameObject.GetComponent<AudioSource>().PlayOneShot(audiofile);
        yield return new WaitForSecondsRealtime(audiofile.length);
        audiofile = Resources.Load("Manuel/manuel_01Hospital") as AudioClip;
        this.gameObject.GetComponent<AudioSource>().PlayOneShot(audiofile);
        yield return new WaitForSecondsRealtime(audiofile.length);
    }
    public void Update()
    {
        if (!this.gameObject.GetComponent<AudioSource>().isPlaying && !listo)
        {
            seleccionarBoton();
            GameObject obj = GameObject.Find(boton1.GetComponent<PlayBut>().opcion);
            string txt = "Jorge/";
            txt= string.Concat(txt, obj.GetComponentInChildren<Text>().text);
            audiofile = Resources.Load(txt) as AudioClip;
            this.gameObject.GetComponent<AudioSource>().PlayOneShot(audiofile);
        }
    }
    public void seleccionarBoton()
    {
        seleccionado = boton1;
        seleccionado.GetComponent<Button>().Select();
        listo = true;
    }

}
