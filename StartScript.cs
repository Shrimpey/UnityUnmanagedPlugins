using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class StartScript : MonoBehaviour {
    
    //-------------------  SECTION 1 - Simple types   ------------------------------------------------
    //-------------------  1.1. Returning simple type    ---------------------------------------------
    [DllImport("cpp", EntryPoint = "SimpleTypeReturnFun")]
    private static extern int SimpleTypeReturnFun();

    //-------------------  1.2. Passing simple type    -----------------------------------------------
    [DllImport("cpp", EntryPoint = "SimpleTypeArgFun")]
    private static extern int SimpleTypeArgFun(int n);

    //-------------------  1.3. Passing reference    -------------------------------------------------
    [DllImport("cpp", EntryPoint = "ReferenceArgumentFun")]
    private static extern int ReferenceArgumentFun(ref int n);

    //-------------------  SECTION 1 - Callbacks   ---------------------------------------------------
    //-------------------  2.1. Simple Callback    ---------------------------------------------------
    private delegate void SimpleCallback();
    [DllImport("cpp", EntryPoint = "SimpleCallbackFun")]
    private static extern void SimpleCallbackFun(SimpleCallback c);


    void Start () {
        Run1_1();
        Run1_2();
        Run1_3();

        Run2_1();
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



    private void Run2_1() {
        SimpleCallback sc = new SimpleCallback(SimpleCallbackUnityFun);
        SimpleCallbackFun(sc);
    }

    private void SimpleCallbackUnityFun() {
        Debug.Log("2.1. Output: \tSimple callback.");
    }
}
