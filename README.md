# Trabajo Final Programación II UAPA 2025

## Base de datos

- Script para crear base de datos
- 
```sql
-- Crear el esquema "inventario"
CREATE SCHEMA inventario;

-- Crear la tabla "productos" dentro del esquema
CREATE TABLE inventario.productos (
    id_producto SERIAL PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    precio NUMERIC(10, 2) CHECK (precio > 0),
    stock INTEGER,
    fecha_registro DATE DEFAULT CURRENT_DATE
);
```

- Script para consultar los productos

```sql
SELECT id_producto, nombre, precio, stock, fecha_registro
	FROM inventario.productos;
```

## Requerimientos para ejecutar programa

- Instalar visual studio 2022 - comunnity edition
- Tener instalado .NET 8 runtime environmment

```shell
# Verificar que net8 esta instalado
$> dotnet --version
8.0.302
```

- Tener instalado git para windos

```shell
# Verificar que git esta instalado
$> git version

# Ir a la carpeta donde quierar tener el proyecto
$> cd C:\Users\<usuario.Windows>\source\repos

# clonar el repositorio
$> git clone https://github.com/Jerajo/Trabajo-Final-Programacion.git

# Pasa guardar los cambios
$> git add .
$> git commit -m "mensaje del commit"
$> git push
```

- Tener instalados postgreSql y pgAdmin
- Ejecutar script para crear base de datos
- Validar la conección a la base de datos

```csharp
string connectionString = "Host=localhost:5432;Username=postgres;Password=0123.;Database=postgres";
```
