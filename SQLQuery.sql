SELECT *
FROM Clientes
ORDER BY Clientes.DataCadastro DESC;

/**/

SELECT *
FROM Produtos 
ORDER BY Produtos.DataRegistro DESC;

/**/

SELECT COUNT(*) FROM Clientes;
SELECT COUNT(*) AS Total_Clientes FROM Clientes;

/**/

SELECT COUNT(*) FROM Produtos;
SELECT COUNT(*) AS Total_Produtos FROM Produtos;
