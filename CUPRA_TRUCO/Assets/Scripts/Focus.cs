using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Focus : MonoBehaviour
{
    public int totalLevels;
    public Scrollbar sBar;

    public int valueFocus;
    public bool choose = false;

    int totalRows;

    // Start is called before the first frame update
    void Start()
    {
        float res = totalLevels / 1.0f;
        totalRows = Mathf.CeilToInt(res);
    }

    // Update is called once per frame
    void Update()
    {
        if(choose)
        {
            choose = false;
            FocusButton();
        }
    }

    public void FocusButton()
    {
        float auxRes = (valueFocus - 1) / 1.0f;
        auxRes = totalRows - auxRes;
        int move = Mathf.CeilToInt(auxRes);
        float normalize = move / totalRows;
        sBar.value = normalize;
    }
}
