select * from tb_Categoria;

CREATE PROCEDURE SP_Rol_List
as
select idROl, nombreRol from tb_Rol;

exec SP_Rol_List;

select idRol, nombreRol from tb_Rol
where idRol=3;

------------------------------------------------------------------------------------

--Uso de OFSET-FETCH

DECLARE @tamPagina AS BIGINT = 5,
		@numPagina AS BIGINT = 1;

SELECT * FROM tb_Colaborador
--es importante declarar el ordenar 'ORDER BY' (ascendente o descendente)
ORDER BY idColaborador --DESC
OFFSET (@numPagina - 1) * @tamPagina ROWS
FETCH NEXT @tamPagina ROWS ONLY;

------------------------------------------------------------------------------------

CREATE PROCEDURE SP_ROL_Insert
(@nombreRol varchar(20))
as
INSERT INTO tb_Rol(nombreRol)
values (@nombreRol);


SELECT * FROM tb_Rol;

------------------------------------------------------------------------------------

CREATE PROCEDURE SP_ROL_InsertListar
(@nombreRol varchar(20))
as
INSERT INTO tb_Rol(nombreRol)
values (@nombreRol)
SELECT idROL, nombreRol FROM tb_Rol;

exec SP_ROL_InsertListar 'Rol Prueba 2';

------------------------------------------------------------------------------------
CREATE PROCEDURE SP_ROL_BuscarID
(@idRol int)
as
SELECT idROL, nombreRol FROM tb_Rol
where @idRol = idRol;


exec SP_ROL_BuscarID '2';