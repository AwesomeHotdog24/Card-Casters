using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName="New Spell", menuName="Spell")]
public class Spell : ScriptableObject
{
    public int dammage=1;
    public Sprite spellImage=null;
    public float spellRange=1;
}
