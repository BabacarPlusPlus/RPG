using UnityEngine;
using System.Collections;

public class ObjetRessouce : Objet {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public ObjetRessouce() {}
    public ObjetRessouce(int id, string nom, int valeur,string desc, Detail detail, EnumTypeObjet to)
    {
        _id = id;
        _nom = nom;
        _valeur = valeur;
        _description = desc;
        _detail = new Detail();
        _detail = detail;
        _typeObjet = to;
    }
    public ObjetRessouce(int id, string nom, int valeur, string desc, EnumTypeObjet to, int vie, int mana, int init, int force, int magie, int def, int chance)
    {
        _id = id;
        _nom = nom;
        _valeur = valeur;
        _description = desc;
        _detail = new Detail(vie,mana,init,force,magie,def,chance);
        _typeObjet = to;
    }

    
}
