using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class StartScript : MonoBehaviour {

    //------------------------------------------------------------------------------------------------
    //-------------------  SECTION 1 - Simple types      ---------------------------------------------
    //------------------------------------------------------------------------------------------------

    //-------------------  1.1. Returning simple type    ---------------------------------------------
    [DllImport("cpp", EntryPoint = "SimpleTypeReturnFun")]
    private static extern int SimpleTypeReturnFun();

    //-------------------  1.2. Passing simple type    -----------------------------------------------
    [DllImport("cpp", EntryPoint = "SimpleTypeArgFun")]
    private static extern int SimpleTypeArgFun(int n);

    //-------------------  1.3. Passing reference    -------------------------------------------------
    [DllImport("cpp", EntryPoint = "ReferenceArgumentFun")]
    private static extern int ReferenceArgumentFun(ref int n);




    //------------------------------------------------------------------------------------------------
    //-------------------  SECTION 2 - Callbacks   ---------------------------------------------------
    //------------------------------------------------------------------------------------------------

    //-------------------  2.1. Simple Callback    ---------------------------------------------------
    private delegate void SimpleCallback();
    [DllImport("cpp", EntryPoint = "SimpleCallbackFun")]
    private static extern void SimpleCallbackFun(SimpleCallback c);

    //-------------------  2.2. Simple Callback with return type    ----------------------------------
    private delegate int SimpleReturnCallback();
    [DllImport("cpp", EntryPoint = "SimpleReturnCallbackFun")]
    private static extern int SimpleReturnCallbackFun(SimpleReturnCallback c);

    //-------------------  2.3. Simple Callback taking single argument    ----------------------------
    private delegate void SimpleArgCallback(int n);
    [DllImport("cpp", EntryPoint = "SimpleArgCallbackFun")]
    private static extern void SimpleArgCallbackFun(SimpleArgCallback c);


    void Start () {
        //Running section 1 test cases
        Run1_1();
        Run1_2();
        Run1_3();

        //Running section 2 test cases
        Run2_1();
        Run2_2();
        Run2_3();
    }

    //-------------------  Section 1 test functions   -------------------------------------------------
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



    //-------------------  Section 2 test functions   -------------------------------------------------
    private void Run2_1() {
        SimpleCallback sc = new SimpleCallback(SimpleCallbackUnityFun);
        SimpleCallbackFun(sc);
    }
    private void SimpleCallbackUnityFun() {
        Debug.Log("2.1. Output: \tSimple callback.");
    }


    private void Run2_2() {
        SimpleReturnCallback sc = new SimpleReturnCallback(SimpleReturnCallbackUnityFun);
        Debug.Log("2.2. Output: \t" + SimpleReturnCallbackFun(sc));
    }
    private int SimpleReturnCallbackUnityFun() {
        return 5;
    }


    private void Run2_3() {
        SimpleArgCallback sc = new SimpleArgCallback(SimpleArgCallbackUnityFun);
        SimpleArgCallbackFun(sc);
    }
    private void SimpleArgCallbackUnityFun(int n) {
        Debug.Log("2.3. Output: \t" + n);
    }
}
