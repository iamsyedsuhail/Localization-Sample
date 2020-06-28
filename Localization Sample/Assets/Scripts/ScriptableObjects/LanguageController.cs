﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LanguageController", menuName = "ScriptableObjects/LanguageController", order = 1)]
public class LanguageController : ScriptableObject
{
    public int languageIndex = 0;
    public List<LanguageData> languageDatas = new List<LanguageData>();
}
