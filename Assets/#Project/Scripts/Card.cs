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

    public List<AttackType> attackType;

    public Sprite cardFront;
    public Sprite cardBack;
    public Sprite ragePicto;


    public enum AttackType
    {
        Light,
        Heavy,
    }
}
