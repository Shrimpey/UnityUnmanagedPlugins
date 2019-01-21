#pragma once

#ifdef BUILD_DLL
    #define DLL_EXPORT __declspec(dllexport)
#else
    #define DLL_EXPORT __declspec(dllimport)
#endif

extern "C"{
    int DLL_EXPORT SimpleTypeReturnFun();           //1.1.
    int DLL_EXPORT SimpleTypeArgFun(int n);         //1.2.
    void DLL_EXPORT ReferenceArgumentFun(int& n);   //1.3.

    typedef void (*SimpleCallback)();
    void DLL_EXPORT SimpleCallbackFun(SimpleCallback c);   //2.1.
    typedef int (*SimpleReturnCallback)();
    int DLL_EXPORT SimpleReturnCallbackFun(SimpleReturnCallback c);   //2.2.
    typedef void (*SimpleArgCallback)(int n);
    void DLL_EXPORT SimpleArgCallbackFun(SimpleArgCallback c);   //2.3.
}
