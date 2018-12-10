using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName = "Character")]
public class Character : ScriptableObject
{

    public string characterName = "Default";
    public int startingHp = 100;

    public Ability[] characterAbilities;

}