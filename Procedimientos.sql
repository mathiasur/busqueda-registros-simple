--BUSQUEDA DE DATOS EXACTOS
SELECT * FROM Clientes WHERE Nombre = 'romeo'

--BUSQUEDA DE DATOS POR APROXIMACION
SELECT * FROM Clientes WHERE Nombre = 'Zo%'

--PROCEDIMIENTO
CREATE PROC VerRegistros
@Condicion nvarchar(30)
AS
SELECT * FROM Clientes WHERE 
ID LIKE @Condicion+'%' 
OR Nombre LIKE @Condicion+'%'
OR Apellido LIKE @Condicion+'%'
OR Direccion LIKE @Condicion+'%'
OR Ciudad LIKE @Condicion+'%'
OR Email LIKE @Condicion+'%'
OR Telefono LIKE @Condicion+'%'
OR Ocupacion LIKE @Condicion+'%'

GO

