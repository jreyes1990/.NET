## Alex Joel Pagoada Suazo

### Documentación de ASP.NET
    https://learn.microsoft.com/es-es/aspnet/core/?view=aspnetcore-8.0

### Descarga .NET
    https://dotnet.microsoft.com/es-es/download

### Información general sobre .NET en Linux
    https://learn.microsoft.com/es-mx/dotnet/core/install/linux-ubuntu

### Descarga Visual Studio (Solo Windows)
    https://visualstudio.microsoft.com/es/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030&passive=false&WT.mc_id=dotnet-35129-website

### Descarga Visual Studio Code
    https://code.visualstudio.com/Download?WT.mc_id=dotnet-35129-website

### Tutorial de .NET
    https://learn.microsoft.com/es-mx/dotnet/core/tutorials/top-level-templates

### Instrucciones
Para crear un proyecto de .NET debe realizar lo siguiente en consola de Linux.

    dotnet new console -n cursoNetCore --use-program-main

Para ejecutar un proyecto de .NET debe realizar lo siguiente en consola de Linux.

    dotnet run

### Mover el archivo .gitignore a la raíz del proyecto
Primero, asegúrate de que el archivo .gitignore esté en la raíz de tu repositorio. Si accidentalmente lo colocaste en una ubicación incorrecta, muévelo a la raíz del proyecto.

    mv ../../.gitignore ./

### Limpiar el índice de Git y actualizar .gitignore
El siguiente paso es asegurarse de que Git deje de rastrear los archivos que deberían ser ignorados:

Remover los archivos no deseados del índice:

Esto quitará los archivos de construcción (como bin/ y obj/) del control de versiones.

    git rm -r --cached bin/
    git rm -r --cached obj/


 