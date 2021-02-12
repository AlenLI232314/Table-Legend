using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Dice { Four, Six, Eight, Ten, Twelve, Twenty };
public class DiceRoller : MonoBehaviour
{
    public int FourSidedDieResult;
    public int SixSidedDieResult;
    public int EightSidedDieResult;
    public int TenSidedDieResult;
    public int TwelveSidedDieResult;
    public int TwentySidedDieResult;

    public void RollDice(Dice Die)
    {
        switch (Die)
        {
            case Dice.Four:
                FourSidedDieResult = Random.Range(1, 5);
                break;

            case Dice.Six:
                SixSidedDieResult = Random.Range(1, 7);
                break;

            case Dice.Eight:
                EightSidedDieResult = Random.Range(1, 9);
                break;

            case Dice.Ten:
                TenSidedDieResult = Random.Range(1, 11);
                break;

            case Dice.Twelve:
                TwelveSidedDieResult = Random.Range(1, 13);
                break;

            case Dice.Twenty:
                TwentySidedDieResult = Random.Range(1, 21);
                break;
        }
    }
}
