using UnityEngine;

public class orderingsystem : MonoBehaviour
{
    //camelCasing i.e variables
    private float _costofcoffee = 4;

    private int coffeeamountordered;

    public float totalOrderAmount;

    //pascal casing i.e method, classes, properties
    public void AmountPlaced(int coffeeamountordered)
    {
        totalOrderAmount = coffeeamountordered * _costofcoffee;
        Debug.Log("Your Order Amount Today Is" + " £ " + totalOrderAmount);
    }
}

//access modifiers
//void = private void
//void
//public void = public void

//if public can be seen outside class (script)
//if private cannot be seen outside class (script)