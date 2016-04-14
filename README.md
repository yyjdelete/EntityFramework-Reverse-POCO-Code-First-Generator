***Not official. Just an test for me to learn EF7. Do not use in the production environment!***  
Tested with EntityFramework.Core 7.0.0-rc1-final

## Limited
1. `System.Data.Entity.Spatial.DbGeography`,`System.Data.Entity.Spatial.DbGeometry` and `System.Data.Entity.Hierarchy.HierarchyId` is not supported by EF7.  
2. `CodeFirstStoreFunctions` is not supported in EF7.  
3. Stored Procedures for query is not supported by EF7(Only raw query for mapped table is supported now).  
4. My code is too ugly.  
5. __Use some helper classes, so support more than one Context in an project is not supported.__  
6. __FakeDbContext may not works(Not tested).__ InMemoryProvider should be used for test in EF7.  
7. Not work with many2many map.  

---

## EntityFramework Reverse POCO Code First Generator

**Beautifully generated code first code that is fully customisable**
* Downloadable VSIX installer from the [visual studio gallery](https://visualstudiogallery.msdn.microsoft.com/ee4fcff9-0c4c-4179-afd9-7a2fb90f5838).
![Visual Studio Partner](https://i1.visualstudiogallery.msdn.s-msft.com/content/visualstudio/vsippartnerlogonew.png)

### Project Description

Reverse engineers an existing database and generates Entity Framework Code
First Poco classes, Configuration mappings and DbContext. Includes support for WCF.

Watch the [tutorial video](http://visualstudiogallery.msdn.microsoft.com/ee4fcff9-0c4c-4179-afd9-7a2fb90f5838).

Please note, this is not the Microsoft reverse generator.
This is one I created to generate beautiful code-first code, as if I
had hand-crafted the code-first code myself. It also allows me to customise
the generated code to my liking.

### What's new

[Click here](https://github.com/sjh37/efreversepoco/wiki/What's-New) to see what's new in this release.

### Donation

To make a donation via PayPal, [please click here](https://www.paypal.me/SJH37).

### Supported databases

* SQL Server
* SQL Server Compact 4.0

### Highly customisable output

This generator was designed to be customisable from the very beginning,
and not fixed and rigid like other generators.
Go and play with the settings in the `<database>.tt` file, that's what it's there for.

If your database changes, simply re-save the `<database>.tt` file. That's it.

[Click here](https://github.com/sjh37/efreversepoco/wiki/Full-control-over-the-generated-code) to see a full list of features.

### To install and use this project:

* For Visual Studio 2012 & 2013, install Entity Framework 6 Tools
  [available here](http://www.microsoft.com/en-us/download/details.aspx?id=40762)
  This installs the required EF6.Utility.CS.ttinclude which is used for pluralisation
  You only need to do this once.
* Use Nuget and install EntityFramework.
* Add a connect string to your app.config. Something like:
```xml
<connectionStrings>
  <add name="MyDbContext"
       providerName="System.Data.SqlClient"
       connectionString="Data Source=(local);Initial Catalog=MyDatabase;Integrated Security=True; />
</connectionStrings>
```
* The connection string you use must have at least these privileges: `ddladmin`, `datareader` and `datawriter`.
  `ddladmin` is required for reading the default constraints.
* In Visual Studio, right click project and select "add - new item".
* Select Online, and search for **reverse poco**.
* Select **EntityFramework Reverse POCO Generator**.
* Give the file a name, such as `Database.tt` and click Add.
* Edit the `Database.tt` file and specify the connection string as "**MyDbContext**" which matches your name in `app.config`.
* Save the `Database.tt` file, which will now generate the `Database.cs` file.
* There are many options you can use to customise the generated code.
  All of these settings are in the `Database.tt` files.

### UI

A simple UI for the generator is available at
[efreversepocoui.codeplex.com](https://efreversepocoui.codeplex.com/) which helps you
to create a regex to filter your tables.

Regards,
Simon Hughes

* E: [simon@hicrest.net](mailto:simon@hicrest.net)
* W: [about.me/simon.hughes](http://about.me/simon.hughes)
* B: [simon-hughes.blogspot.co.uk](http://simon-hughes.blogspot.co.uk)
