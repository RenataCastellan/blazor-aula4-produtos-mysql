-- Banco de dados da distribuidora (MySQL)
-- Gerado a partir da migration CriarTabelaProdutos do EF Core.

CREATE DATABASE IF NOT EXISTS `distribuidora`;
USE `distribuidora`;

-- Tabela que o EF Core usa para saber quais migrations já foram aplicadas
CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    PRIMARY KEY (`MigrationId`)
);

START TRANSACTION;

-- Tabela de produtos
CREATE TABLE `Produtos` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Nome` varchar(100) NOT NULL,
    `Preco` decimal(10,2) NOT NULL,
    `Quantidade` int NOT NULL,
    PRIMARY KEY (`Id`)
);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20261124230054_CriarTabelaProdutos', '10.0.12');

COMMIT;
