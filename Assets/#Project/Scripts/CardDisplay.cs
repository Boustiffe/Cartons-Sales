using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public Card cardData;

    public Image cardFront;
    public Image cardBack;
    public Image cardSprite;
    public Image attackPicto;
    public Image ragePicto;
    public Image buffedZoneImage;

    public TMP_Text nameText;
    public TMP_Text baseDescription;
    public TMP_Text buffedDescription;

    private Color[] rageColors =
    {
        new Color (0f, 0.5927502f, 1f), //Blue
        new Color (1f, 0.5609636f, 0f), //Orange
        new Color (1f, 0f, 0f) //Red
    };

        private Color[] rageColorsUI =
    {
        new Color (0f, 0.5927502f, 1f, 0.9f), //Blue
        new Color (1f, 0.5609636f, 0f, 0.9f), //Orange
        new Color (1f, 0f, 0f, 0.9f) //Red
    };


    private Color[] attackTypeColors =
    {
        new Color (1f, 0.9226508f, 0f), //Yellow
        new Color (0.4792453f, 0.2751139f, 0.1293058f) //Brown
    };


    void Start()
    {
        UpdateCardDisplay();
    }

    public void UpdateCardDisplay()
    {
        attackPicto.color = attackTypeColors[(int)cardData.attackType[0]];
        ragePicto.color = rageColors[(int)cardData.rageAim[0]];
        buffedZoneImage.color = rageColorsUI[(int)cardData.rageCondition[0]];

        nameText.text = cardData.cardName;
        baseDescription.text = cardData.baseDescription;
        buffedDescription.text = cardData.buffedDescription;

        cardSprite.sprite = cardData.cardSprite;
    }
}