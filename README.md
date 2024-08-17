# Projecto Wayni

## Información

Este proyecto permite la configuración de un perfil de usuario con ReactJS como front-end y una api .NET.

Al ingresar a la web por primera vez, se creará automáticamente un usuario con la siguiente información:

```
{
        email: "salazar6cristopher@gmail.com",
        name: "Cristopher Salazar",
        password: "123456",
        phone: "930199050",
        username: "ccriistopher",
}

```

## Requisitos previos

- NodeJS
- Visual Studio 2022

## Iniciando Backend

1. Ingresar a la carpeta del backend

   ```
   cd WayniApi
   ```

2. Instalar certificados

   ```
   dotnet dev-certs https --trust
   ```

3. Iniciar aplicación

   ```
   dotnet run --launch-profile https
   ```

## Iniciando Frontend

1. Ingresar a la carpeta frontend

   ```
   cd wayni-ts
   ```

2. Instalar dependencias

   ```
   npm install
   ```

3. Iniciar aplicación

   ```
   npm start
   ```

4. Abrir el siguiente url en un navegador web

   ```
   http://localhost:3000/
   ```

## Contraseña por defecto

Para actualizar la contraseña, por defecto es 123456
