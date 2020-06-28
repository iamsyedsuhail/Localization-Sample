# Localization-Sample
Unity Localization Sample  using scriptable objects

This method is very much suitable only for games with minimal texts, i have used it in my latest game, works fine considering my usecases.

How to start?

Two main scripts:

LanguageData.cs
LanguageController.cs

Language Data holds values of your specific language ("play","completed",etc)
Language Contoller holds reference of all created Language Data.

You can create a new Language Data and assign values specific to your needs. (right click on project view, select Create->Scriptable Objects->Lanugage Data)
Just like above steps, create Language Controller, now load Language Data in your Langauge Controller.

Now that you have created data and controller,simply create a reference for your language controller in your UIManager, then assign values to your ui elements using these langauge data.

