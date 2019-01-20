using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class StartScript : MonoBehaviour {
    
    //-------------------  1.1. Returning simple type    ---------------------------------------------
    [DllImport("cpp", EntryPoint = "SimpleTypeReturnFun")]
    private static extern int SimpleTypeReturnFun();

    //-------------------  1.2. Passing simple type    ---------------------------------------------
    [DllImport("cpp", EntryPoint = "SimpleTypeArgFun")]
    private static extern int SimpleTypeArgFun(int n);

    //-------------------  1.3. Passing reference    ---------------------------------------------
    [DllImport("cpp", EntryPoint = "ReferenceArgumentFun")]
    private static extern int ReferenceArgumentFun(ref int n);

    void Start () {
        Run1_1();
        Run1_2();
        Run1_3();
    }

    private void Run1_1() {
        Debug.Log("1.1. Output: \t" + SimpleTypeReturnFun());
    }
    private void Run1_2() {
        Debug.Log("1.2. Output: \t" + SimpleTypeArgFun(2));
    }
    private void Run1_3() {
        int tempInt = 3;
        ReferenceArgumentFun(ref tempInt);
        Debug.Log("1.3. Output: \t" + tempInt);
    }

}
