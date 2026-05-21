using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoinManager : MonoBehaviour
{
    [SerializeField]
    private int coinCount = 0;

    [SerializeField]
    private int specialCoinCount = 0;

    [SerializeField]
    private UnityEvent changeCoinCountAction = null;

    [SerializeField]
    private UnityEvent changeSpecialCoinCountAction = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCoin(int count)
    {
        coinCount += count;
        changeCoinCountAction?.Invoke();
    }

    public void AddSpecialCoin(int count)
    {
        specialCoinCount += count;
        changeSpecialCoinCountAction?.Invoke();
    }

    public int GetCoinCount()
    {
        return coinCount;
    }

    public int GetSpecialCoinCount()
    {
        return specialCoinCount;
    }

}
