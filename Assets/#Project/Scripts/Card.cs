using UnityEngine;
using System.Collections.Generic;

//Après avoir cherché sur le net, il semble que le seul moyen de créer des ScriptableObjects est de passer par un script C#
[CreateAssetMenu(fileName = "New Card", menuName = "Scriptable Objects/New Card")]
public class Card : ScriptableObject
{
    public int normalDamage;
    public int buffedDamage;

    public string effect;
    public string baseDescription;
    public string buffedDescription;
    public string cardName;

    public List<AttackType> attackType;
    public List<RageStatus> rageAim;
    public List<RageStatus> rageCondition;

    public Sprite cardFront;
    public Sprite cardBack;
    public Sprite cardSprite;


    public enum AttackType
    {
        Light,
        Heavy,
    }

    public enum RageStatus
    {
        Blue,
        Orange,
        Red,
    }
}
