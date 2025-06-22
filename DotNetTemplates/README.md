# Installing Templates

**Install a single DotNetTemplate from its subdirectory**
Navigate to the specific template directory before running the install command:

```powershell
content\TemplateDirectory> dotnet new install .\
```

**Install all DotNetTemplates located in the `content` folder**
Navigate to the root directory that contains the `content` folder:

```powershell
\DotNetTemplates> dotnet new install ./content
```

**Install all DotNetTemplates using an absolute path**
No need to change directory when using an absolute path:

```powershell
dotnet new install "R:\Toic.Templates\DotNetTemplates\content"
```

---

# Uninstalling Templates

**Uninstall a single template from its directory**
Navigate to the template directory used during installation:

```powershell
content\TemplateDirectory> dotnet new uninstall .\
```

**Uninstall all templates installed from the `content` folder (relative path)**
Navigate to the root directory containing the `content` folder:

```powershell
\DotNetTemplates> dotnet new uninstall ./content
```

**Uninstall templates using an absolute path**

```powershell
dotnet new uninstall "R:\Toic.Templates\DotNetTemplates\content"
```

---


# Examples:
https://github.com/dotnet/templating/tree/main/dotnet-template-samples

https://github.com/dotnet/templating/wiki/Reference-for-template.json