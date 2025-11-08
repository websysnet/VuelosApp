# ✈️ VuelosApp

## 📋 Descripción
VuelosApp es una aplicación desarrollada en .NET que permite gestionar información relacionada con vuelos. Esta aplicación está construida utilizando las últimas tecnologías de .NET y sigue las mejores prácticas de desarrollo.

## 🚀 Características
- Gestión de vuelos
- Información de aeropuertos
- Reservas de boletos
- Seguimiento de horarios
- Sistema de búsqueda avanzada

## 🛠️ Tecnologías Utilizadas
- .NET 9.0
- C#
- Entity Framework Core (opcional)
- SQL Server (opcional)

## ⚙️ Requisitos Previos
- .NET 9.0 SDK o superior
- IDE (Visual Studio 2022 recomendado)
- SQL Server (opcional, dependiendo de la implementación)

## 🏗️ Estructura del Proyecto
```
VuelosApp/
├── Program.cs          # Punto de entrada de la aplicación
└── VuelosApp.csproj    # Archivo de proyecto .NET
```

## 📥 Instalación
1. Clona el repositorio:
```powershell
git clone [url-del-repositorio]
```

2. Navega al directorio del proyecto:
```powershell
cd VuelosApp
```

3. Restaura los paquetes NuGet:
```powershell
dotnet restore
```

4. Ejecuta la aplicación:
```powershell
dotnet run
```


## � Docker
Puedes ejecutar VuelosApp fácilmente en cualquier sistema con Docker y Docker Compose:

### 1. Construir y ejecutar con Docker Compose
```powershell
docker-compose build
docker-compose up
```
Esto construirá la imagen y abrirá la app en modo interactivo en consola.

### 2. Usar solo Docker
```powershell
docker build -t vuelosapp:latest .
docker run --rm -it --name vuelosapp vuelosapp:latest
```
El parámetro `-it` permite la interacción con el menú de la aplicación.

---
Si tienes Docker Desktop instalado, puedes usar la terminal integrada o cualquier consola compatible.

---
## 💡 Uso
1. Clona el repo.
2. Instala el SDK .NET 9.
3. Ejecuta:
	```powershell
	dotnet build
	dotnet run
	```
4. Se abrirá una terminal de opciones.

## 🤝 Contribución
Las contribuciones son bienvenidas. Por favor, sigue estos pasos:
<!-- 1. Haz Fork del proyecto
2. Crea una rama para tu característica (`git checkout -b feature/AmazingFeature`)
3. Haz commit de tus cambios (`git commit -m 'Add some AmazingFeature'`)
4. Push a la rama (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request -->

## 📄 Licencia
Este proyecto está bajo la Licencia MIT - ver el archivo [LICENSE](LICENSE) para más detalles.

## ✍️ Autor
Piero Villata

## 📞 Contacto
- GitHub: [@websysnet](https://github.com/websysnet)

---
⌨️ con ❤️ por Piero Villata