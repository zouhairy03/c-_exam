-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: Feb 03, 2024 at 09:03 AM
-- Server version: 5.7.34
-- PHP Version: 8.0.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `BankDatabase`
--

-- --------------------------------------------------------

--
-- Table structure for table `Clients`
--

CREATE TABLE `Clients` (
  `ClientId` int(11) NOT NULL,
  `Nom` varchar(255) NOT NULL,
  `Prenom` varchar(255) NOT NULL,
  `Adresse` varchar(255) NOT NULL,
  `NumeroTelephone` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `Clients`
--

INSERT INTO `Clients` (`ClientId`, `Nom`, `Prenom`, `Adresse`, `NumeroTelephone`) VALUES
(1, 'Alice', 'Johnson', '456 Oak St', '555-5678'),
(2, 'Alice', 'Johnson', '456 Oak St', '555-5678'),
(3, 'Zouhair', 'Youssef', '789 Pine St', '555-9876'),
(4, 'roe', 'nxnc', '456 Oak St', '233-5232'),
(5, 'alssa', 'aowew', '789 jsjdds 22', '555-222e'),
(6, 'roe', 'nxnc', '456 Oak St', '233-5232'),
(7, 'alssa', 'aowew', '789 jsjdds 22', '555-222e'),
(8, 'roe', 'nxnc', '456 Oak St', '233-5232'),
(9, 'alssa', 'aowew', '789 jsjdds 22', '555-222e'),
(10, 'roe', 'nxnc', '456 Oak St', '233-5232'),
(11, 'alssa', 'aowew', '789 jsjdds 22', '555-222e'),
(12, 'roe', 'nxnc', '456 Oak St', '233-5232'),
(13, 'alssa', 'aowew', '789 jsjdds 22', '555-222e');

-- --------------------------------------------------------

--
-- Table structure for table `Comptes`
--

CREATE TABLE `Comptes` (
  `CompteId` int(11) NOT NULL,
  `ClientId` int(11) DEFAULT NULL,
  `Solde` decimal(18,2) DEFAULT NULL,
  `TypeCompte` varchar(255) NOT NULL,
  `DateOuverture` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `Comptes`
--

INSERT INTO `Comptes` (`CompteId`, `ClientId`, `Solde`, `TypeCompte`, `DateOuverture`) VALUES
(1, 1, '1500.00', 'Checking', '2024-02-02 19:54:36'),
(2, 1, '1500.00', 'Checking', '2024-02-02 19:57:30'),
(3, 1, '1500.00', 'Checking', '2024-02-03 09:14:25'),
(4, 2, '2000.00', 'Savings', '2024-02-03 09:14:25'),
(5, 1, '1500.00', 'Checking', '2024-02-03 09:18:07'),
(6, 2, '2000.00', 'Savings', '2024-02-03 09:18:07'),
(7, 1, '1500.00', 'Checking', '2024-02-03 09:35:45'),
(8, 2, '2000.00', 'Savings', '2024-02-03 09:35:45'),
(9, 1, '1500.00', 'Checking', '2024-02-03 09:49:42'),
(10, 2, '2000.00', 'Savings', '2024-02-03 09:49:42'),
(11, 1, '1500.00', 'Checking', '2024-02-03 09:54:40'),
(12, 2, '2000.00', 'Savings', '2024-02-03 09:54:40');

-- --------------------------------------------------------

--
-- Table structure for table `Transactions`
--

CREATE TABLE `Transactions` (
  `TransactionId` int(11) NOT NULL,
  `CompteId` int(11) DEFAULT NULL,
  `TypeTransaction` varchar(255) NOT NULL,
  `Montant` decimal(18,2) DEFAULT NULL,
  `DateTransaction` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `Transactions`
--

INSERT INTO `Transactions` (`TransactionId`, `CompteId`, `TypeTransaction`, `Montant`, `DateTransaction`) VALUES
(1, 1, 'Withdrawal', '200.00', '2024-02-02 19:54:36'),
(2, 1, 'Withdrawal', '200.00', '2024-02-02 19:57:30'),
(3, 1, 'Withdrawal', '200.00', '2024-02-03 09:14:25'),
(4, 2, 'Deposit', '500.00', '2024-02-03 09:14:25'),
(5, 1, 'Withdrawal', '200.00', '2024-02-03 09:18:07'),
(6, 2, 'Deposit', '500.00', '2024-02-03 09:18:07'),
(7, 1, 'Withdrawal', '200.00', '2024-02-03 09:35:45'),
(8, 2, 'Deposit', '500.00', '2024-02-03 09:35:45'),
(9, 1, 'Withdrawal', '200.00', '2024-02-03 09:49:42'),
(10, 2, 'Deposit', '500.00', '2024-02-03 09:49:42'),
(11, 1, 'Withdrawal', '200.00', '2024-02-03 09:54:40'),
(12, 2, 'Deposit', '500.00', '2024-02-03 09:54:40');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Clients`
--
ALTER TABLE `Clients`
  ADD PRIMARY KEY (`ClientId`);

--
-- Indexes for table `Comptes`
--
ALTER TABLE `Comptes`
  ADD PRIMARY KEY (`CompteId`),
  ADD KEY `ClientId` (`ClientId`);

--
-- Indexes for table `Transactions`
--
ALTER TABLE `Transactions`
  ADD PRIMARY KEY (`TransactionId`),
  ADD KEY `CompteId` (`CompteId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Clients`
--
ALTER TABLE `Clients`
  MODIFY `ClientId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `Comptes`
--
ALTER TABLE `Comptes`
  MODIFY `CompteId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `Transactions`
--
ALTER TABLE `Transactions`
  MODIFY `TransactionId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `Comptes`
--
ALTER TABLE `Comptes`
  ADD CONSTRAINT `comptes_ibfk_1` FOREIGN KEY (`ClientId`) REFERENCES `Clients` (`ClientId`);

--
-- Constraints for table `Transactions`
--
ALTER TABLE `Transactions`
  ADD CONSTRAINT `transactions_ibfk_1` FOREIGN KEY (`CompteId`) REFERENCES `Comptes` (`CompteId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
