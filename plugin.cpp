#include "plugin.h"

#include <string>

extern "C"{
    int DLL_EXPORT SimpleTypeReturnFun(){                           //1.1.
        return 1;
    }

    int DLL_EXPORT SimpleTypeArgFun(int n){                         //1.2.
        return n;
    }

    void DLL_EXPORT ReferenceArgumentFun(int &n){                   //1.3.
        n=4;
    }

    void DLL_EXPORT SimpleCallbackFun(SimpleCallback c){            //2.1.
        c();
    }

    int DLL_EXPORT SimpleReturnCallbackFun(SimpleReturnCallback c){      //2.2.
        return c();
    }

    void DLL_EXPORT SimpleArgCallbackFun(SimpleArgCallback c){         //2.3.
        c(6);
    }
}
