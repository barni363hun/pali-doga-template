CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
);

CREATE TABLE `professions` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_professions` PRIMARY KEY (`Id`)
);

CREATE TABLE `competitors` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `SchoolName` varchar(200) CHARACTER SET utf8mb4 NULL,
    `BirthDate` datetime(6) NULL,
    `Hostel` tinyint(1) NOT NULL,
    `AvatarUrl` varchar(100) CHARACTER SET utf8mb4 NULL,
    `ProfessionId` int NOT NULL,
    CONSTRAINT `PK_competitors` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_competitors_professions_ProfessionId` FOREIGN KEY (`ProfessionId`) REFERENCES `professions` (`Id`) ON DELETE CASCADE
);

INSERT INTO `professions` (`Id`, `Name`)
VALUES (1, 'Szoftverfejlesztő és tesztelő');
INSERT INTO `professions` (`Id`, `Name`)
VALUES (2, 'Informatikai rendszer- és alkalmazás üzemeltető');
INSERT INTO `professions` (`Id`, `Name`)
VALUES (3, 'CAD-CAM informatikus');
INSERT INTO `professions` (`Id`, `Name`)
VALUES (4, 'Gépgyártástechnológiai technikus');
INSERT INTO `professions` (`Id`, `Name`)
VALUES (5, 'Gazdasági informatikus');

CREATE INDEX `IX_competitors_ProfessionId` ON `competitors` (`ProfessionId`);

CREATE UNIQUE INDEX `IX_professions_Name` ON `professions` (`Name`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20220328111120_init', '3.1.19');

