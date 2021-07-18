select * from tb_Rol;

create procedure SP_ROL_List
as
select idRol, nombreRol from tb_Rol;

exec SP_ROL_List