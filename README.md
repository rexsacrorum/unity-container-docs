[![Build status](https://ci.appveyor.com/api/projects/status/50hjsoi3gqu1becr?svg=true)](https://ci.appveyor.com/project/unitycontainer/documentation)

# Unity Documentation

This repository hosts source files and instructions for building Unity documentation site: https://unitycontainer.github.io 

If you'd like to contribute documentation or report an issue please do it in [this repository](https://github.com/unitycontainer/documentation).

## Building the documentation

The documentation is built using [DocFX](https://dotnet.github.io/docfx/). To build the documentation, you need to install DocFX. You can do this by running the following command:

```bash
dotnet tool install -g docfx
```

After installing DocFX, you can build the documentation by running the following command:

```bash
docfx docfx.json
```

The generated documentation will be in the `_site` directory.

Or you can use the following command to build and serve the documentation locally:

```bash
docfx docfx.json --serve
```
s