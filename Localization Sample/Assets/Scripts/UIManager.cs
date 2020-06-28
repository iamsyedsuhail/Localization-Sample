using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//NOTE: This method is suitable for games with few text prefarably a casual mobile game or any game with less than 20-30 texts.
//If it is more than that, there are much better ways than this.

public class UIManager : MonoBehaviour
{

    [SerializeField]
    private LanguageController _languageController;

    private LanguageData _selectedLanguage;
    private int _iLangaugeIndex = 0;

    [SerializeField]
    private Text _titleText;
    [SerializeField]
    private Text _playButtonText;
    [SerializeField]
    private Dropdown _dropdown;
    private void Awake()
    {
        ChangeSelectedLangauge(_iLangaugeIndex);//0 for english index
    }

    //assign accordingly to text in the ui
    private void SetTextForUI()
    {
        _titleText.text = _selectedLanguage.title; 
        _playButtonText.text = _selectedLanguage.play;
    }

    //selects language using id
    private void ChangeSelectedLangauge(int id)
    {
        _selectedLanguage = _languageController.languageDatas[_iLangaugeIndex];
        SetTextForUI();// set text accordingly language data
    }

    //this triggers when dropdown value is changes, this function is hooked to the dropdown component in the canvas
    //the value parameter here is useless we are using it so we can hook this to component, unitys on changed trigger doesnt work properly
    //for dropdown menus.
    public void LanguageDropDownValueChanged(int val)
    {
        _iLangaugeIndex = _dropdown.value;
        ChangeSelectedLangauge(_iLangaugeIndex);
    }

}
