using UnityEngine;
using System.Collections;


public class Equipement : MonoBehaviour
{
    private ObjetEquipable _arme;
    private ObjetEquipable _casque;   
    private ObjetEquipable _torse;    
    private ObjetEquipable _accesoire1;
    private ObjetEquipable _accesoire2;
    private ObjetEquipable _accesoire3;   
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public Equipement(){}
    public void porterEquipement(ObjetEquipable obj, Sac sac)
    {
        if (obj.getTypeObjet() == EnumTypeObjet.ARME)
        {
            if (_arme != null)
            {
                sac.ajouterObjet(_arme);
                _arme = obj;                
            }
            else
            {
                _arme = obj;
            }
        }
        if (obj.getTypeObjet() == EnumTypeObjet.CASQUE)
        {
            if (_casque != null)
            {
                sac.ajouterObjet(_casque);
                _casque = obj;
               
            }
            else
            {
                _casque = obj;
            }
           
        }
        if (obj.getTypeObjet() == EnumTypeObjet.TORSE)
        {
            if (_torse != null)
            {
                sac.ajouterObjet(_torse);
                _torse = obj;            
               
            }
            else
            {
                _torse = obj;
            }
        }
        if (obj.getTypeObjet() == EnumTypeObjet.ACCESSOIRE)
        {
            //retoucher ici
            if (_accesoire1 == null)
            {
                _accesoire1 = obj;
            }
            else if (_accesoire2 == null)
            {
                _accesoire2 = obj;
            }
            else if (_accesoire3 == null)
            {
                _accesoire3 = obj;
            }
            else ;

        }


       
    }
    public void enleverEquipement(ObjetEquipable obj, Sac sac)
    {
        //retoucher
        sac.ajouterObjet(obj);

        if(obj.getTypeObjet() == EnumTypeObjet.ARME)
            _arme = null;

        if (obj.getTypeObjet() == EnumTypeObjet.CASQUE)
             _casque = null;

        if (obj.getTypeObjet() == EnumTypeObjet.TORSE)
            _torse = null;

        if (obj.getTypeObjet() == EnumTypeObjet.ACCESSOIRE)
            _accesoire3 = null;
    }

    public ObjetEquipable Arme
    {
        get { return _arme; }
        set { _arme = value; }
    }
    public ObjetEquipable Casque
    {
        get { return _casque; }
        set { _casque = value; }
    }
    public ObjetEquipable Torse
    {
        get { return _torse; }
        set { _torse = value; }
    }
    public ObjetEquipable Accesoire1
    {
        get { return _accesoire1; }
        set { _accesoire1 = value; }
    }
    public ObjetEquipable Accesoire2
    {
        get { return _accesoire2; }
        set { _accesoire2 = value; }
    }
    public ObjetEquipable Accesoire3
    {
        get { return _accesoire3; }
        set { _accesoire3 = value; }
    }
}
