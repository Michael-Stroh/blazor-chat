  <h1 align="center" style="color:green; font-size: 300%;" > blazor-chat  </h1>

 
This is a chat app implemented in Blazor and SignalR by Michael Ströh for Allegiance consulting, apart of the interview process. 

  <h1 align="left" style="color:blue; font-size: 200%;" > Technology Stack  </h1>
  
<div style="margin-left: 4%">

- [Blazor WASM](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
- [Bootstrap](https://getbootstrap.com/)
- [Razor components](https://docs.microsoft.com/en-us/aspnet/core/blazor/components/?view=aspnetcore-6.0)
- [ASP.NET Core Web Application](https://docs.microsoft.com/en-us/visualstudio/ide/quickstart-aspnet-core?view=vs-2022)
- [SignalR](https://dotnet.microsoft.com/apps/aspnet/signalr)

</div>

  <h1 align="left" style="color:blue; font-size: 200%;" > Getting Started  </h1>

<div style="margin-left: 4%">
First thing would be to create the generic Blazor WASM files, this can be created using either the terminal or an ide (I used <a href="https://visualstudio.microsoft.com/vs/community/"> Visual Studio Community </a> )

# Visual Studio

Firstly select create a new project

<img align="left" width="80" src="https://github.com/Michael-Stroh/blazor-chat/blob/59f0fe8e711e0d7884466bbd07447b5a3e7ded35/Images/Install/create.png">

Select the Blazor WASM project
<img align="left" width="80" src="https://github.com/Michael-Stroh/blazor-chat/blob/59f0fe8e711e0d7884466bbd07447b5a3e7ded35/Images/Install/blazor_select.png">

Type in the name of tha application
<img align="left" width="80" src="https://github.com/Michael-Stroh/blazor-chat/blob/59f0fe8e711e0d7884466bbd07447b5a3e7ded35/Images/Install/configure.png">

Add the additional information as such (pay attention to selected boxes)
<img align="left" width="80" src="https://github.com/Michael-Stroh/blazor-chat/blob/59f0fe8e711e0d7884466bbd07447b5a3e7ded35/Images/Install/additional.png">    
    
# Command Line

<pre>
    dotnet new blazorwasm --hosted
</pre>
</div>

  <h1 align="left" style="color:blue; font-size: 200%;" > How To Run  </h1>

<div style="margin-left: 4%">

# Visual Studio

Select the debug toolbar option
<img align="left" width="80" src="https://github.com/Michael-Stroh/blazor-chat/blob/59f0fe8e711e0d7884466bbd07447b5a3e7ded35/Images/Run/toolbar.png">

Select start without debugging
<img align="left" width="80" src="https://github.com/Michael-Stroh/blazor-chat/blob/59f0fe8e711e0d7884466bbd07447b5a3e7ded35/Images/Run/select.png">

The web app will start in your default browser.
    
# Command Line
    
Ensure to open a command line in the directory the project is saved.

Go into the server directory
<pre>
    cd server
</pre>

Run the project
<pre>
    dotnet run
</pre>

Navigate to the address https://localhost:5001 to view the web app.
    
</div>






