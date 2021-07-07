
select cli.idCliente, cli.nombreCliente, cli.apellidosCliente, cli.numeroDocumentoCliente, td.nombreTipoDocumento
from tb_Cliente cli inner join tb_TipoDocumento td
on cli.idTipoDocumento = td.idTipoDocumento
inner join tb_Categoria cat
on cli.idCategoria = cat.idCategoria;

/*
Selecciona los 5 campos de
la tabla 1 unico con 2 ......
que tienen relación con el campo "x"
*/

/*
de la tabla 1 unido con 2 ...
relacionado con el campo "x"
agrupa
ordena
selecciona los "y" campos
*/


select * from tb_ContactoCliente;

select tcc.idContactabilidad, tco.nombreColaborador, tcl.nombreCliente, tpr.nombreProducto
from tb_ContactoCliente tcc inner join tb_Colaborador tco
on tcc.idColaborador = tco.idColaborador
inner join tb_Cliente tcl
on tcc.idCliente = tcl.idCliente
inner join tb_Producto tpr
on tcc.idProducto = tpr.idProducto;
