
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class PlayBut : MonoBehaviour
{
    public AudioSource ASource;
    public string opcion;
    AudioClip audiofile;
    public void Audio()
    {
        ASource.Stop();
        GameObject busca = GameObject.Find(opcion);
        string audionomb=busca.GetComponentInChildren<Text>().text;
        audionomb = string.Concat("Jorge/",audionomb);
        audiofile = Resources.Load(audionomb) as AudioClip;
        ASource.PlayOneShot(audiofile);
    }

}