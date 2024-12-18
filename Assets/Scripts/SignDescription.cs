using UnityEngine;
using System;
using System.Collections.Generic;
[CreateAssetMenu(fileName = "SignDescription", menuName = "Scriptable Objects/SignDescription")]
public class SignDescription : ScriptableObject
{
    [SerializeField] private List<String> phrases;
}
