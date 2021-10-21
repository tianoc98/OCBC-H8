-- phpMyAdmin SQL Dump
-- version 4.9.7
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Oct 21, 2021 at 07:08 PM
-- Server version: 10.3.30-MariaDB-cll-lve
-- PHP Version: 7.3.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `u1029352_payments`
--

-- --------------------------------------------------------

--
-- Table structure for table `AspNetRoleClaims`
--

CREATE TABLE `AspNetRoleClaims` (
  `Id` int(11) NOT NULL,
  `RoleId` varchar(255) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetRoles`
--

CREATE TABLE `AspNetRoles` (
  `Id` varchar(255) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUserClaims`
--

CREATE TABLE `AspNetUserClaims` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(255) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUserLogins`
--

CREATE TABLE `AspNetUserLogins` (
  `LoginProvider` varchar(128) NOT NULL,
  `ProviderKey` varchar(128) NOT NULL,
  `ProviderDisplayName` longtext DEFAULT NULL,
  `UserId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUserRoles`
--

CREATE TABLE `AspNetUserRoles` (
  `UserId` varchar(255) NOT NULL,
  `RoleId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUsers`
--

CREATE TABLE `AspNetUsers` (
  `Id` varchar(255) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` longtext DEFAULT NULL,
  `SecurityStamp` longtext DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL,
  `PhoneNumber` longtext DEFAULT NULL,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `AspNetUsers`
--

INSERT INTO `AspNetUsers` (`Id`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`) VALUES
('45a48e07-8d42-42ec-ad01-8d2b0e60dcf2', 'Tian', 'TIAN', 'Tian@Gmail.com', 'TIAN@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEKFwjRMRu9CzHw5Pn2POz99gTrs687071t5ZU6Pbo+Eayt8EAWX8YKUHgI17Mcv2Lw==', 'M43EEUYJ4JKZ255WFGZZVBWGEEBJ66IS', 'cac7abf3-78a1-4b10-bbd3-2f69832270c9', NULL, 0, 0, NULL, 1, 0),
('46b9d655-ad3f-44b2-bcfa-accf4bb6ee7e', 'Tian1', 'TIAN1', 'Tian1@gmail.com', 'TIAN1@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAECvgYwB7JlFvEYZtv9MhTKTRvN9KQTNMw6SzH0NTvcepZcTSjxSoHL2BBAO+zIqbZA==', '26VGLKIK7U7MNME7TR2MI66XSRW4CF5Y', '9468d9fb-b6b9-4668-a9e9-8379d655f0ec', NULL, 0, 0, NULL, 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `AspNetUserTokens`
--

CREATE TABLE `AspNetUserTokens` (
  `UserId` varchar(255) NOT NULL,
  `LoginProvider` varchar(128) NOT NULL,
  `Name` varchar(128) NOT NULL,
  `Value` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `CardInfo`
--

CREATE TABLE `CardInfo` (
  `Id` int(11) NOT NULL,
  `CustomerName` longtext DEFAULT NULL,
  `CardName` longtext DEFAULT NULL,
  `CardInfo` longtext DEFAULT NULL,
  `SecurityCode` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `CardInfo`
--

INSERT INTO `CardInfo` (`Id`, `CustomerName`, `CardName`, `CardInfo`, `SecurityCode`) VALUES
(2, 'TestUpdate', 'string', 'string', 'string'),
(3, 'string', 'string', 'string', 'string');

-- --------------------------------------------------------

--
-- Table structure for table `DetailPayments`
--

CREATE TABLE `DetailPayments` (
  `Id` int(11) NOT NULL,
  `Pay` double NOT NULL,
  `DetailsPayment` longtext DEFAULT NULL,
  `CustomerName` longtext DEFAULT NULL,
  `PaymentDate` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `DetailPayments`
--

INSERT INTO `DetailPayments` (`Id`, `Pay`, `DetailsPayment`, `CustomerName`, `PaymentDate`) VALUES
(3, 1000000, 'TestUpdate', 'string', '2021-10-21 11:55:00.810000'),
(4, 1000000, 'BCA', 'Tian', '2021-10-21 11:33:55.007000');

-- --------------------------------------------------------

--
-- Table structure for table `RefreshTokens`
--

CREATE TABLE `RefreshTokens` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(255) DEFAULT NULL,
  `Token` longtext DEFAULT NULL,
  `JwtId` longtext DEFAULT NULL,
  `IsUsed` tinyint(1) NOT NULL,
  `IsRevorked` tinyint(1) NOT NULL,
  `AddedDate` datetime(6) NOT NULL,
  `ExpiryDate` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `RefreshTokens`
--

INSERT INTO `RefreshTokens` (`Id`, `UserId`, `Token`, `JwtId`, `IsUsed`, `IsRevorked`, `AddedDate`, `ExpiryDate`) VALUES
(1, '45a48e07-8d42-42ec-ad01-8d2b0e60dcf2', 'FTMMZ5WOIHXQX7A217F5W0CEB5Q3S4MNDDNab02db79-1b17-4690-823c-63b7739afd82', '0abbf964-3b84-4e7e-aa23-33f8a3d64a12', 0, 0, '2021-10-21 11:25:19.398891', '2022-04-21 11:25:19.398930'),
(2, '46b9d655-ad3f-44b2-bcfa-accf4bb6ee7e', 'C7DSEKHO4ATQL6HTDS10HFWPAK3UMPD915D9e9dd13a-85d0-4169-87c4-deef7e8f5f2b', '3224e0f3-ee66-4271-af93-356a7af61696', 0, 0, '2021-10-21 11:29:07.557681', '2022-04-21 11:29:07.557730'),
(3, '45a48e07-8d42-42ec-ad01-8d2b0e60dcf2', 'A1YM4HQXX0HUT3KRY2KA4RIZJS03PCD798Lb02f1ef4-5018-4f0b-b952-a44e33b3a951', 'cd362797-1f01-4098-adcb-757cf4f24eed', 0, 0, '2021-10-21 11:29:51.313426', '2022-04-21 11:29:51.313427'),
(4, '45a48e07-8d42-42ec-ad01-8d2b0e60dcf2', 'Q1S4ZIHW1NVZB0MQ3NBZILE2L4QQ2CIBVJDaa0ca3da-1fce-4613-8c46-2c5a5e41bbd6', '55aa9f62-df34-4eb3-a59e-1f1ec74c83c9', 0, 0, '2021-10-21 11:33:35.201529', '2022-04-21 11:33:35.201570'),
(5, '45a48e07-8d42-42ec-ad01-8d2b0e60dcf2', '0SV0X9JEIY1XTIJ8FLELMGW6DWFTFFFSFTE8f0cf9ab-5dff-4e8f-af7d-c0f74b7f98ac', '9617041b-d859-467b-bf16-a7a28e6f30ec', 0, 0, '2021-10-21 11:50:52.731925', '2022-04-21 11:50:52.731967'),
(6, '45a48e07-8d42-42ec-ad01-8d2b0e60dcf2', 'S71DULIZ3OLWIFAWYG5X9WM7R8LZ3Y7X8SH3b72e0a5-bc74-4ca3-b3ca-156b9781e0b7', 'aa0e518f-cf75-4b25-ae4a-69405796ead8', 0, 0, '2021-10-21 11:55:29.832897', '2022-04-21 11:55:29.832936');

-- --------------------------------------------------------

--
-- Table structure for table `__EFMigrationsHistory`
--

CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `__EFMigrationsHistory`
--

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`) VALUES
('20211021033215_Initial Migrations', '5.0.11'),
('20211021045712_update migrations', '5.0.11'),
('20211021080432_Add Payments Details', '5.0.11'),
('20211021112333_INI MIGRATIONS', '5.0.11');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `AspNetRoleClaims`
--
ALTER TABLE `AspNetRoleClaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`);

--
-- Indexes for table `AspNetRoles`
--
ALTER TABLE `AspNetRoles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- Indexes for table `AspNetUserClaims`
--
ALTER TABLE `AspNetUserClaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- Indexes for table `AspNetUserLogins`
--
ALTER TABLE `AspNetUserLogins`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_AspNetUserLogins_UserId` (`UserId`);

--
-- Indexes for table `AspNetUserRoles`
--
ALTER TABLE `AspNetUserRoles`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_AspNetUserRoles_RoleId` (`RoleId`);

--
-- Indexes for table `AspNetUsers`
--
ALTER TABLE `AspNetUsers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- Indexes for table `AspNetUserTokens`
--
ALTER TABLE `AspNetUserTokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- Indexes for table `CardInfo`
--
ALTER TABLE `CardInfo`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `DetailPayments`
--
ALTER TABLE `DetailPayments`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `RefreshTokens`
--
ALTER TABLE `RefreshTokens`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_RefreshTokens_UserId` (`UserId`);

--
-- Indexes for table `__EFMigrationsHistory`
--
ALTER TABLE `__EFMigrationsHistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `AspNetRoleClaims`
--
ALTER TABLE `AspNetRoleClaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `AspNetUserClaims`
--
ALTER TABLE `AspNetUserClaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `CardInfo`
--
ALTER TABLE `CardInfo`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `DetailPayments`
--
ALTER TABLE `DetailPayments`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `RefreshTokens`
--
ALTER TABLE `RefreshTokens`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `AspNetRoleClaims`
--
ALTER TABLE `AspNetRoleClaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `AspNetUserClaims`
--
ALTER TABLE `AspNetUserClaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `AspNetUserLogins`
--
ALTER TABLE `AspNetUserLogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `AspNetUserRoles`
--
ALTER TABLE `AspNetUserRoles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `AspNetUserTokens`
--
ALTER TABLE `AspNetUserTokens`
  ADD CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `RefreshTokens`
--
ALTER TABLE `RefreshTokens`
  ADD CONSTRAINT `FK_RefreshTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
