using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public Text name, age, location, gender, FavoriteCompany;

    private Name _name;
    private AGL _agl;
    private Company _company;

    private void Start()
    {
        _name = GetComponent<Name>();
        _agl = GameObject.FindObjectOfType<AGL>();
        _company = GameObject.FindObjectOfType<Company>();

        name.text = "Name: " + _name.name;
        age.text = "Age: " + _agl.age;
        location.text = "Location: " + _agl.location;
        gender.text = "Gender: " + _agl.gender;
        FavoriteCompany.text = "Favorite Company: " + _company.favoriteCompany;

    }
}
