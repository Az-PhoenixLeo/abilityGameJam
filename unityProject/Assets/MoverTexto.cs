using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MoverTexto : MonoBehaviour
{
    public Transform Canvas;
    public AudioSource AS;
    public Text opcion1, opcion2, opcion3;
    public Button bot2, bot3;
    AudioClip audf;
    GameObject obj;
    public GameObject menu, salir;
    private void Start()
    {
        menu.SetActive(false);
        salir.SetActive(false);
    }
    private void Update()
    {
        if (menu.activeInHierarchy)
        {
            AS.Stop();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menu.SetActive(true);
            salir.SetActive(true);
        }
    }
    public void Inicio()
    {
        SceneManager.LoadScene("MenuInicio", LoadSceneMode.Single);
    }
    public void Salir()
    {
        Application.Quit();
    }
    public void Boton1()
    {
        AS.Stop();
        MoverTxt();
        Estados(opcion1.text);
        AS.PlayOneShot(audf);
        Buttons.listo = false;
    }
    public void Boton2()
    {
        AS.Stop();
        MoverTxt();
        Estados(opcion2.text);
        AS.PlayOneShot(audf);
        Buttons.listo = false;
    }
    public void Boton3()
    {
        AS.Stop();
        MoverTxt();
        Estados(opcion3.text);
        AS.PlayOneShot(audf);
        Buttons.listo = false;
    }
    public void MoverTxt()
    {
        GameObject[] textos = GameObject.FindGameObjectsWithTag("Texto");
        foreach (GameObject txt in textos)
        {
            txt.transform.Translate(0, 2.5f, 0);
            if (txt.transform.position.y > 4.5f)
            {
                Destroy(txt.gameObject);
            }
        }
    }
    public void Estados(string seleccion)
    {
        switch (seleccion)
        {
            case "Hombre, ¿Que te paso, ¿por que estas ahi":
                obj=(GameObject)Instantiate(Resources.Load("Prefabs/Jorge"),new Vector3(1.7f,.5f,0),Quaternion.identity,Canvas);
                obj.GetComponentInChildren<Text>().text = "Hombre, ¿Que te paso, ¿por que estas ahi";
                audf = Resources.Load("Manuel/Me chocaron, estuve inconsiente un par de dias, y cuando desperte estaba en el hospital y perdi la mayor parte de la vista.") as AudioClip;
                obj=(GameObject) Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity,Canvas);
                obj.GetComponentInChildren<Text>().text = "Me chocaron, estuve inconsiente un par de dias, y cuando desperte estaba en el hospital y perdi la mayor parte de la vista.";
                opcion1.text = "¿Que te han dicho los doctores ¿va a ser algo temporal";
                opcion2.text = "No se ni que decirte";
                opcion3.text = "¿Y quien tuvo la culpa";
                break;
            case "¿Todo bien":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "¿Todo bien";
                audf = Resources.Load("Manuel/No, tuve accidente.") as AudioClip;
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "No, tuve accidente.";
                opcion1.text = "no manches, ¿que paso";
                opcion2.text = "¿Estas bien";
                opcion3.text = "¿Donde estas";
                break;
            case "¿Por fin te hiciste la jarocha":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "¿Por fin te hiciste la jarocha";
                audf = Resources.Load("Manuel/Chinga tu madre.") as AudioClip;
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Chinga tu madre.";
                opcion1.text = "Fin Capitulo 1";
                Destroy(opcion2.transform.parent.gameObject);
                Destroy(bot2.gameObject);
                Destroy(bot3.gameObject);
                Destroy(opcion3.transform.parent.gameObject);
                break;
            case "no manches, ¿que paso":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "no manches, ¿que paso";
                audf = Resources.Load("Manuel/Me chocaron, estuve inconsiente un par de dias, y cuando desperte estaba en el hospital y perdi la mayor parte de la vista.") as AudioClip;
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Me chocaron, estuve inconsiente un par de dias, y cuando desperte estaba en el hospital y perdi la mayor parte de la vista.";
                opcion1.text = "¿Que te han dicho los doctores ¿va a ser algo temporal";
                opcion2.text = "No se ni que decirte";
                opcion3.text = "¿Y quien tuvo la culpa";
                break;
            case "¿Estas bien":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "¿Estas bien";
                audf = Resources.Load("Manuel/Me chocaron, estuve inconsiente un par de dias, y cuando desperte estaba en el hospital y perdi la mayor parte de la vista.") as AudioClip;
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Me chocaron, estuve inconsiente un par de dias, y cuando desperte estaba en el hospital y perdi la mayor parte de la vista.";
                opcion1.text = "¿Que te han dicho los doctores ¿va a ser algo temporal";
                opcion2.text = "No se ni que decirte";
                opcion3.text = "¿Y quien tuvo la culpa";
                break;
            case "¿Donde estas":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "¿Donde estas";
                audf = Resources.Load("Manuel/Estoy en el hospital Dolores Calvario") as AudioClip;
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Estoy en el hospital Dolores Calvario";
                opcion1.text = "¿Estas bien";
                opcion2.text = "Luego te paso a ver";
                opcion3.text = "Que mala suerte";
                break;
            case "¿Y quien tuvo la culpa":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "¿Y quien tuvo la culpa";
                audf = Resources.Load("Manuel/¿Realemente importa quien tuvo la culpa") as AudioClip;
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "¿Realemente importa quien tuvo la culpa";
                opcion1.text = "Bueno tienes que pensar en que pasa despues de que salgas del hospital";
                opcion2.text = "Supongo que no, fue lo unico que se me ocurrio perdon";
                opcion3.text = "Pues si que tal si te meten a la carcel";
                break;
            case "¿Que te han dicho los doctores ¿va a ser algo temporal":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "¿Que te han dicho los doctores ¿va a ser algo temporal";
                audf = Resources.Load("Manuel/De momento los doctores no tienen tanta esperanza que sea temporal, parece que es permamente. El nervio optico tuvo mucho daño cuando me golpee la cabeza durante el choque") as AudioClip;
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "De momento los doctores no tienen tanta esperanza que sea temporal, parece que es permamente. El nervio optico tuvo mucho daño cuando me golpee la cabeza durante el choque";
                opcion1.text = "Lo bueno esque sigues vivo";
                opcion2.text = "No se ni que decirte";
                opcion3.text = "Eso significa que ya se acabaron los jueves de peliculas";
                break;
            case "No se ni que decirte":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "No se ni que decirte";
                audf = Resources.Load("Manuel/te entiendo yo tambien entre en shock.") as AudioClip;
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "te entiendo yo tambien entre en shock.";
                opcion1.text = "¿En que te puedo ayudar";
                opcion2.text = "Que mala suerte";
                opcion3.text = "Perdon te dejo, ya me tengo que ir a trabajar";
                break;
            case "Eso significa que ya se acabaron los jueves de peliculas":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Eso significa que ya se acabaron los jueves de peliculas";
                audf = Resources.Load("Manuel/Chinga tu madre.") as AudioClip;
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Chinga tu madre.";
                opcion1.text = "Fin Capitulo 1";
                Destroy(opcion2.transform.parent.gameObject);
                Destroy(opcion3.transform.parent.gameObject);
                Destroy(bot2.gameObject);
                Destroy(bot3.gameObject);
                break;
            case "Lo bueno esque sigues vivo":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Lo bueno esque sigues vivo";
                audf = Resources.Load("Manuel/Si supongo que podria ser peor, aun asi no me siento bien sin poder ver.") as AudioClip;
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Si supongo que podria ser peor, aun asi no me siento bien sin poder ver.";
                opcion1.text = "¿Quieres que te lleve a tu casa";
                opcion2.text = "Y que piensas hacer";
                opcion3.text = "Oye, y en que estado termino tu Mercedez";
                break;
            case "Bueno tienes que pensar en que pasa despues de que salgas del hospital":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Bueno tienes que pensar en que pasa despues de que salgas del hospital";
                audf = Resources.Load("Manuel/Eso ya lo vere despues, de momento solo quiero llegar a mi casa.") as AudioClip;
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Eso ya lo vere despues, de momento solo quiero llegar a mi casa.";
                opcion1.text = "¿Quieres que te lleve a tu casa";
                opcion2.text = "Luego te veo en tu casa";
                opcion3.text = "Perdon te dejo, ya me tengo que ir a trabajar";
                break;
            case "Supongo que no, fue lo unico que se me ocurrio perdon":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Supongo que no, fue lo unico que se me ocurrio perdon";
                audf = Resources.Load("Manuel/no pasa nada... supongo que igual fue algo fuerte para ti") as AudioClip;
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "no pasa nada... supongo que igual fue algo fuerte para ti";
                opcion1.text = "¿En que te puedo ayudar";
                opcion2.text = "Y que piensas hacer";
                opcion3.text = "Perdon te dejo, ya me tengo que ir a trabajar";
                break;
            case "Pues si que tal si te meten a la carcel":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Pues si que tal si te meten a la carcel";
                audf = Resources.Load("Manuel/En serio deberia de tener mala suerte para que pase eso.") as AudioClip;
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "En serio deberia de tener mala suerte para que pase eso.";
                opcion1.text = "Lo bueno esque sigues vivo";
                opcion2.text = "Y que piensas hacer";
                opcion3.text = "Perdon te dejo, ya me tengo que ir a trabajar";
                break;
            case "¿Quieres que te lleve a tu casa":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "¿Quieres que te lleve a tu casa";
                audf = Resources.Load("Manuel/si porfavor, estoy en el Hospital Dolores Calvario.") as AudioClip;
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "si porfavor, estoy en el Hospital Dolores Calvario.";
                opcion1.text = "Fin Capitulo 1";
                Destroy(opcion2.transform.parent.gameObject);
                Destroy(opcion3.transform.parent.gameObject);
                Destroy(bot2.gameObject);
                Destroy(bot3.gameObject);
                break;
            case "Y que piensas hacer":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Y que piensas hacer";
                audf = Resources.Load("Manuel/de momento solo quiere regresar a mi casa en la tarde que salga.") as AudioClip;
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "de momento solo quiere regresar a mi casa en la tarde que salga.";
                opcion1.text = "¿Quieres que te lleve a tu casa";
                opcion2.text = "Luego te veo en tu casa";
                opcion3.text = "Perdon te dejo, ya me tengo que ir a trabajar";
                break;
            case "Oye, y en que estado termino tu Mercedez":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Oye, y en que estado termino tu Mercedez";
                audf = Resources.Load("Manuel/Destruido, pero gracias por interesarte en mi") as AudioClip;
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Destruido, pero gracias por interesarte en mi";
                opcion1.text = "Fin Capitulo 1";
                Destroy(opcion2.transform.parent.gameObject);
                Destroy(opcion3.transform.parent.gameObject);
                Destroy(bot2.gameObject);
                Destroy(bot3.gameObject);
                break;
            case "¿En que te puedo ayudar":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "¿En que te puedo ayudar";
                audf = Resources.Load("Manuel/Salgo hoy del hospital, ¿Me podrias dar un aventon a mi casa") as AudioClip;
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Salgo hoy del hospital, ¿Me podrias dar un aventon a mi casa";
                opcion1.text = "Claro, solo dime donde estas";
                opcion2.text = "avisame cuando salgas y ahi voy a estar";
                opcion3.text = "Perdon, pero ya tenia planes";
                break;
            case "Que mala suerte":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Que mala suerte";
                audf = Resources.Load("Manuel/Si ya lo se.") as AudioClip;
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Si ya lo se.";
                opcion1.text = "¿En que te puedo ayudar";
                opcion2.text = "Luego te paso a ver";
                opcion3.text = "Perdon te dejo, ya me tengo que ir a trabajar";
                break;
            case "Perdon te dejo, ya me tengo que ir a trabajar":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Perdon te dejo, ya me tengo que ir a trabajar";
                audf = Resources.Load("Manuel/h") as AudioClip;
                opcion1.text = "Fin Capitulo 1";
                Destroy(opcion2.transform.parent.gameObject);
                Destroy(opcion3.transform.parent.gameObject);
                Destroy(bot2.gameObject);
                Destroy(bot3.gameObject);
                break;
            case "Claro, solo dime donde estas":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Claro, solo dime donde estas";
                audf = Resources.Load("Manuel/Estoy en el Hospital Dolores Calvario.") as AudioClip;
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Estoy en el Hospital Dolores del Calvario";
                opcion1.text = "Fin Capitulo 1";
                Destroy(opcion2.transform.parent.gameObject);
                Destroy(opcion3.transform.parent.gameObject);
                Destroy(bot2.gameObject);
                Destroy(bot3.gameObject);
                break;
            case "avisame cuando salgas y ahi voy a estar":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "avisame cuando salgas y ahi voy a estar";
                audf = Resources.Load("Manuel/Claro yo te aviso gracias") as AudioClip;
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Claro yo te aviso gracias";
                opcion1.text = "Fin Capitulo 1";
                Destroy(opcion2.transform.parent.gameObject);
                Destroy(opcion3.transform.parent.gameObject);
                Destroy(bot2.gameObject);
                Destroy(bot3.gameObject);
                break;
            case "Perdon, pero ya tenia planes":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Perdon, pero ya tenia planes";
                audf = Resources.Load("Manuel/h") as AudioClip;
                opcion1.text = "Fin Capitulo 1";
                Destroy(opcion2.transform.parent.gameObject);
                Destroy(opcion3.transform.parent.gameObject);
                Destroy(bot2.gameObject);
                Destroy(bot3.gameObject);
                break;
            case "Luego te paso a ver":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Luego te paso a ver";
                audf = Resources.Load("Manuel/gracias estoy en el Hospital Dolores Calvario") as AudioClip;
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "gracias estoy en el Hospital Dolores Calvario";
                opcion1.text = "Fin Capitulo 1";
                Destroy(opcion2.transform.parent.gameObject);
                Destroy(opcion3.transform.parent.gameObject);
                Destroy(bot2.gameObject);
                Destroy(bot3.gameObject);
                break;
            case "Luego te veo en tu casa":
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Jorge"), new Vector3(1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "Luego te veo en tu casa";
                audf = Resources.Load("Manuel/ok") as AudioClip;
                obj = (GameObject)Instantiate(Resources.Load("Prefabs/Manuel"), new Vector3(-1.7f, 0, 0), Quaternion.identity, Canvas);
                obj.GetComponentInChildren<Text>().text = "ok";
                opcion1.text = "Fin Capitulo 1";
                Destroy(opcion2.transform.parent.gameObject);
                Destroy(opcion3.transform.parent.gameObject);
                Destroy(bot2.gameObject);
                Destroy(bot3.gameObject);
                break;
            default:
                SceneManager.LoadScene("MenuInicio",LoadSceneMode.Single);
                break;
        }
            
    }
}
