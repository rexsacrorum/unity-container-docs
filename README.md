[![Build status](https://ci.appveyor.com/api/projects/status/50hjsoi3gqu1becr?svg=true)](https://ci.appveyor.com/project/unitycontainer/documentation)

# Unity Documentation

This repository hosts source files and instructions for building Unity documentation site: https://sacrorum.com/unity-container-docs/ 

## Building the documentation

The documentation is built using [DocFX](https://dotnet.github.io/docfx/). You can build the documentation by running the following command::

```bash
dotnet docfx docfx.json
```

The generated documentation will be in the `_site` directory.

Or you can use the following command to build and serve the documentation locally:

```bash
dotnet docfx docfx.json --serve
```
