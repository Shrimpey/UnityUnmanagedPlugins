# UnityUnmanagedPlugins
This is a database of sample c++ functions that can be run from Unity C# script.
New functions will be added as well as a full c++ in Unity tutorial in this readme file.

### Section 0 - Creating the plugin
To create an unmanaged plugin for Unity you need to do the following:

- create c++ file with DLL_EXPORT defined like in plugin.h example (or just copy the sample files - plugin.h and plugin.cpp)
- compile project into a DLL (if you are using CodeBlocks or similar IDE make sure to compile it with compiler appropriate to your architecture - 32 or 64 bit, also do not compile for Debug as Unity will have problems reading the plugin)
- move created dll file to Unity (Assets/Plugins), make sure to do it while Unity Editor is closed - plugins can only be updated this way
- create a C# script with the sample code in Unity and attach it to an empty gameobject, rename "cpp" in dllimport sections to your plugin name

### Section 1 - Simple arguments and return types

1.1. This function showcases how to receive simple type from c++.

1.2. This function showcases how to pass simple type to c++.

1.3. This function showcases how to pass argument by reference to c++.

### Section 2 - Callbacks

2.1. This function showcases how to trigger simple Unity callback from c++.

2.2. This function showcases how to trigger Unity callback that returns simple type from c++.

2.3. This function showcases how to trigger Unity callback that takes simple argument from c++.

### Further sections - WIP
