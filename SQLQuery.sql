INSERT INTO
	Produtos
VALUES
	('Esse produto será deletado', 'Esse produto tem uma função: SER DELETADO', '999.99', '999', NULL);

SELECT
	*
FROM
	Produtos;

SELECT
	*
FROM
	Clientes;

SELECT
	*
FROM
	Clientes
ORDER BY
	Clientes.DataCadastro
DESC;

SELECT COUNT(*) FROM Clientes;
SELECT COUNT(Id) FROM Clientes;
SELECT COUNT(Nome) FROM Clientes;
