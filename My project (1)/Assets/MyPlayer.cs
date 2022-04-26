using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyPlayer : MonoBehaviour
{
    public int ammoNumber = 0;

    public Text ammoNmbUI;

    // Start is called before the first frame update
    void Start()
    {
        ammoNmbUI.text = ammoNumber.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        Ammo(ammoNumber);
    }
    public void Ammo(int ammoNumber)
    {
        ammoNmbUI.text = ammoNumber.ToString("0");
    }
}
