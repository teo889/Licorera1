CREATE DATABASE db_licorera;
GO

USE db_licorera;
GO

-- 1. Métodos de Pago
CREATE TABLE MetodosPagos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL
);

-- 2. Proveedores
CREATE TABLE Proveedores (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Telefono NVARCHAR(20) NOT NULL
);

-- 3. Empleados
CREATE TABLE Empleados (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(40) NOT NULL,
    Apellido NVARCHAR(40) NOT NULL,
    Cedula NVARCHAR(40) NOT NULL,
    Telefono NVARCHAR(40) NOT NULL
);

-- 4. Departamentos
CREATE TABLE Departamentos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL
);

-- 5. Municipios
CREATE TABLE Municipios (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    DepartamentoId INT NOT NULL FOREIGN KEY REFERENCES Departamentos(Id)
);

-- 6. Promociones
CREATE TABLE Promociones (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(200) NOT NULL
);

-- 7. Vehículos
CREATE TABLE Vehiculos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Placa NVARCHAR(20) NOT NULL,
    Tipo NVARCHAR(50) NOT NULL,
    Descripcion NVARCHAR(50) NOT NULL
);

-- 8. Tipos de Licores
CREATE TABLE Tipolicores (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Descripcion NVARCHAR(200) NULL
);

-- 9. Domiciliarios
CREATE TABLE Domiciliarios (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Cedula NVARCHAR(50) NULL,
    Tipo NVARCHAR(100) NULL,
    VehiculoId INT NOT NULL FOREIGN KEY REFERENCES Vehiculos(Id)
);

-- 10. Direcciones
CREATE TABLE Direcciones (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Descripcion NVARCHAR(200) NOT NULL,
    DepartamentoId INT NOT NULL FOREIGN KEY REFERENCES Departamentos(Id),
    MunicipioId INT NOT NULL FOREIGN KEY REFERENCES Municipios(Id)
);

-- 11. Clientes
CREATE TABLE Clientes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombres NVARCHAR(100) NOT NULL,
    Apellidos NVARCHAR(100) NOT NULL,
    Telefono NVARCHAR(50) NOT NULL,
    Cedula NVARCHAR(50) NOT NULL,
    DireccionId INT NOT NULL FOREIGN KEY REFERENCES Direcciones(Id)
);

-- 12. Productos
CREATE TABLE Productos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    PrecioUnitario DECIMAL(12,2) NOT NULL,
    ProveedorId INT NOT NULL FOREIGN KEY REFERENCES Proveedores(Id),
    TipoLicorId INT NOT NULL FOREIGN KEY REFERENCES Tipolicores(Id)
);

-- 13. Facturas
CREATE TABLE Facturas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Fecha DATE NOT NULL,
    SubTotal DECIMAL(12,2) NOT NULL,
    Iva DECIMAL(12,2) NOT NULL,
    ClienteId INT NOT NULL FOREIGN KEY REFERENCES Clientes(Id),
    MetodoPagoId INT NOT NULL FOREIGN KEY REFERENCES MetodosPagos(Id),
    PromocionId INT NULL FOREIGN KEY REFERENCES Promociones(Id)
);

-- 14. Domicilios
CREATE TABLE Domicilios (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Descripcion NVARCHAR(200) NOT NULL,
    FechaEntrega DATE NULL,
    ClienteId INT NOT NULL FOREIGN KEY REFERENCES Clientes(Id),
    DomiciliarioId INT NOT NULL FOREIGN KEY REFERENCES Domiciliarios(Id),
    FacturaId INT NOT NULL FOREIGN KEY REFERENCES Facturas(Id)
);

-- 15. DetalleFacturas
CREATE TABLE DetalleFacturas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FacturaId INT NOT NULL FOREIGN KEY REFERENCES Facturas(Id),
    ProductoId INT NOT NULL FOREIGN KEY REFERENCES Productos(Id),
    Cantidad INT NOT NULL,
    Total DECIMAL(12,2) NOT NULL
);

GO

-- 1. Métodos de Pago
INSERT INTO MetodosPagos (Nombre) VALUES
('Efectivo'),
('Tarjeta Crédito'),
('Tarjeta Débito'),
('Nequi'),
('Daviplata'),
('Transferencia Bancaria');

-- 2. Proveedores
INSERT INTO Proveedores (Nombre, Telefono) VALUES
('Distribuidora Bogotá', '3101234567'),
('Licores Medellín', '3159876543'),
('Bebidas Cali', '3127654321'),
('Distribuciones Barranquilla', '3181122334'),
('Licores Cartagena', '3112233445'),
('Bebidas Pereira', '3133344556');

-- 3. Empleados
INSERT INTO Empleados (Nombre, Apellido, Cedula, Telefono) VALUES
('Juan', 'Pérez', '1012345678', '3001112233'),
('María', 'Gómez', '1023456789', '3012233445'),
('Carlos', 'Rodríguez', '1034567890', '3023344556'),
('Ana', 'Martínez', '1045678901', '3034455667'),
('Luis', 'Ramírez', '1056789012', '3045566778'),
('Paola', 'Torres', '1067890123', '3056677889');

-- 4. Departamentos
INSERT INTO Departamentos (Nombre) VALUES
('Bogotá D.C.'),
('Antioquia'),
('Valle del Cauca'),
('Atlántico'),
('Bolívar'),
('Risaralda');

-- 5. Municipios
INSERT INTO Municipios (Nombre, DepartamentoId) VALUES
('Bogotá', 1),
('Medellín', 2),
('Cali', 3),
('Barranquilla', 4),
('Cartagena', 5),
('Pereira', 6);

-- 6. Promociones
INSERT INTO Promociones (Nombre, Descripcion) VALUES
('Descuento 10%', 'Descuento del 10% en compras superiores a $100.000'),
('Promo Whisky', 'Promoción de whisky 2x1'),
('Licor Gratis', 'Compra 3 y llévate 1 gratis'),
('Envío Gratis', 'Domicilio gratuito en pedidos mayores a $50.000'),
('Fines de Semana', 'Descuento especial fines de semana'),
('Mes del Cliente', '10% de descuento durante todo el mes');

-- 7. Vehiculos
INSERT INTO Vehiculos (Placa, Tipo, Descripcion) VALUES
('ABC123', 'Moto', 'Moto Yamaha azul'),
('DEF456', 'Carro', 'Carro Chevrolet Spark'),
('GHI789', 'Moto', 'Moto Suzuki roja'),
('JKL012', 'Carro', 'Carro Kia Picanto'),
('MNO345', 'Moto', 'Moto Honda negra'),
('PQR678', 'Carro', 'Carro Renault Logan');

-- 8. Tipolicores
INSERT INTO Tipolicores (Nombre, Descripcion) VALUES
('Whisky', 'Whisky importado y nacional'),
('Ron', 'Ron colombiano y caribeño'),
('Vodka', 'Vodka premium'),
('Tequila', 'Tequila 100% agave'),
('Aguardiente', 'Aguardiente colombiano'),
('Cerveza', 'Cerveza artesanal y comercial');

-- 9. Domiciliarios
INSERT INTO Domiciliarios (Nombre, Cedula, Tipo, VehiculoId) VALUES
('Pedro Morales', '1012345671', 'Motorizado', 1),
('Sofía Ríos', '1012345672', 'Automovilista', 2),
('Jorge Salazar', '1012345673', 'Motorizado', 3),
('Catalina Ruiz', '1012345674', 'Automovilista', 4),
('Andrés López', '1012345675', 'Motorizado', 5),
('Daniela Pérez', '1012345676', 'Automovilista', 6);

-- 10. Direcciones
INSERT INTO Direcciones (Descripcion, DepartamentoId, MunicipioId) VALUES
('Calle 10 # 20-30', 1, 1),
('Carrera 50 # 10-20', 2, 2),
('Avenida 3 # 45-67', 3, 3),
('Calle 30 # 12-34', 4, 4),
('Carrera 7 # 56-78', 5, 5),
('Avenida 10 # 22-44', 6, 6);

-- 11. Clientes
INSERT INTO Clientes (Nombres, Apellidos, Telefono, Cedula, DireccionId) VALUES
('Andrés', 'García', '3101234567', '1012345670', 1),
('Laura', 'Martínez', '3112233445', '1012345671', 2),
('Julián', 'Torres', '3123344556', '1012345672', 3),
('Daniela', 'Ramírez', '3134455667', '1012345673', 4),
('Miguel', 'Hernández', '3145566778', '1012345674', 5),
('Natalia', 'Pérez', '3156677889', '1012345675', 6);

-- 12. Productos
INSERT INTO Productos (Nombre, PrecioUnitario, ProveedorId, TipoLicorId) VALUES
('Whisky Chivas', 120000, 1, 1),
('Ron Medellín', 80000, 2, 2),
('Vodka Absolut', 90000, 3, 3),
('Tequila Jose Cuervo', 95000, 4, 4),
('Aguardiente Antioqueño', 50000, 5, 5),
('Cerveza Poker', 3000, 6, 6);

-- 13. Facturas
INSERT INTO Facturas (Fecha, SubTotal, Iva, ClienteId, MetodoPagoId, PromocionId) VALUES
('2025-09-18', 120000, 21600, 1, 1, 1),
('2025-09-18', 80000, 14400, 2, 2, 2),
('2025-09-18', 90000, 16200, 3, 3, 3),
('2025-09-18', 95000, 17100, 4, 4, 4),
('2025-09-18', 50000, 9000, 5, 5, 5),
('2025-09-18', 3000, 540, 6, 6, 6);

-- 14. Domicilios
INSERT INTO Domicilios (Descripcion, FechaEntrega, ClienteId, DomiciliarioId, FacturaId) VALUES
('Entrega rápida', '2025-09-18', 1, 1, 1),
('Entrega estándar', '2025-09-18', 2, 2, 2),
('Entrega exprés', '2025-09-18', 3, 3, 3),
('Entrega nocturna', '2025-09-18', 4, 4, 4),
('Entrega nocturna', '2025-09-18', 5, 5, 5),
('Entrega estandar', '2025-09-18', 6, 6, 6);

-- 15. DetalleFacturas
INSERT INTO DetalleFacturas (FacturaId, ProductoId, Cantidad, Total) VALUES
(1, 1, 1, 120000),
(2, 2, 1, 80000),
(3, 3, 1, 90000),
(4, 4, 1, 95000),
(5, 5, 1, 50000),
(6, 6, 1, 3000);

GO

