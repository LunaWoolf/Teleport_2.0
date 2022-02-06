using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue",menuName = "RandomeDialogue")]
public class RandomDialogue : ScriptableObject
{
    [TextArea(2, 5)]
    public string[] text;

}

