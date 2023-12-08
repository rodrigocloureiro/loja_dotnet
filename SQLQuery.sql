SELECT
	*
FROM
	Clientes
ORDER BY
	Clientes.DataCadastro
DESC;

/**/

SELECT *
FROM Produtos 
ORDER BY Produtos.DataRegistro DESC;

/**/

SELECT COUNT(*) FROM Clientes;
SELECT COUNT(Id) FROM Clientes;
SELECT COUNT(Nome) FROM Clientes;

/**/

SELECT COUNT(*) FROM Produtos;
SELECT COUNT(Nome) FROM Produtos;
