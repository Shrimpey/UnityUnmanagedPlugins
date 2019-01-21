#include "plugin.h"

#include <string>

extern "C"{
    int DLL_EXPORT SimpleTypeReturnFun(){
        return 1;
    }

    int DLL_EXPORT SimpleTypeArgFun(int n){
        return n;
    }

    void DLL_EXPORT ReferenceArgumentFun(int &n){
        n=4;
    }

    void DLL_EXPORT SimpleCallbackFun(SimpleCallback c){
        c();
    }
}
