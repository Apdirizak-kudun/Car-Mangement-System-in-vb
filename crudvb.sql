-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 05, 2024 at 09:10 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `crudvb`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `id` int(11) NOT NULL,
  `username` varchar(200) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id`, `username`, `password`) VALUES
(1, 'abdi', '123');

-- --------------------------------------------------------

--
-- Table structure for table `cars`
--

CREATE TABLE `cars` (
  `id` int(11) NOT NULL,
  `brand` varchar(200) DEFAULT NULL,
  `year` varchar(200) DEFAULT NULL,
  `color` varchar(200) DEFAULT NULL,
  `fuel` varchar(200) DEFAULT NULL,
  `price` decimal(10,2) DEFAULT NULL,
  `availability` varchar(200) DEFAULT NULL,
  `custID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cars`
--

INSERT INTO `cars` (`id`, `brand`, `year`, `color`, `fuel`, `price`, `availability`, `custID`) VALUES
(1, 'Toyota', '1998', 'Red', 'Patrol', 199.99, 'NO', 1),
(2, 'Tesla', '2021', 'Grey', 'Electric Mode', 299.99, 'NO', 2),
(7, 'Noah', '2002', 'White', 'Patrol', 99.99, 'Yes', NULL),
(8, 'Waaraad', '1989', 'Red', 'Dissel', 300.00, 'NO', NULL),
(9, 'Probox', '2015', 'White', 'Patrol', 89.99, 'NO', NULL),
(10, 'Surf', '1998', 'Black', 'Dissel', 88.99, 'NO', NULL),
(11, 'Bullut Proof', '2019', 'White', 'Patrol', 1289.99, 'Yes', NULL),
(12, 'BMW', '2010', 'BlueGrey', 'Patrol', 899.99, 'Yes', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `custID` int(11) NOT NULL,
  `custName` varchar(200) DEFAULT NULL,
  `custAddress` varchar(200) DEFAULT NULL,
  `custPhone` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`custID`, `custName`, `custAddress`, `custPhone`) VALUES
(2, 'Ibraahim ilkacase', 'Sheikh-Ali', '3434343'),
(4, 'Abdirisaaq', 'Nafaqada', '4343434'),
(5, 'Ahmed Shaakir', 'Xalane', '787654'),
(6, 'Sayid Mohamed', 'Taleex', '4798764'),
(7, 'Faarax Oomaar', 'JigJiga', '47837484'),
(8, 'Muuse Ali', 'Mudug', '7464733');

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `custID` int(11) NOT NULL,
  `custName` varchar(200) DEFAULT NULL,
  `custAddress` varchar(200) DEFAULT NULL,
  `custPhone` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`custID`, `custName`, `custAddress`, `custPhone`) VALUES
(0, 'Omar', 'Fardaha', '74638'),
(1, 'Ibraahim', 'Sheikh Ali', '352627'),
(2, 'Abdirisaaq', 'Nafaqada', '3432222'),
(4, 'Shaakir', 'Xalane', '479'),
(5, 'Duraan', 'Mudug', '3425679');

-- --------------------------------------------------------

--
-- Table structure for table `rents`
--

CREATE TABLE `rents` (
  `id` int(11) NOT NULL,
  `custID` int(11) DEFAULT NULL,
  `custName` varchar(200) DEFAULT NULL,
  `custAddress` varchar(200) DEFAULT NULL,
  `custPhone` varchar(200) DEFAULT NULL,
  `carBrand` varchar(200) DEFAULT NULL,
  `carColor` varchar(200) DEFAULT NULL,
  `fuel` varchar(200) DEFAULT NULL,
  `carPrice` varchar(200) DEFAULT NULL,
  `availability` varchar(200) DEFAULT NULL,
  `rentDate` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `returnDate` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rents`
--

INSERT INTO `rents` (`id`, `custID`, `custName`, `custAddress`, `custPhone`, `carBrand`, `carColor`, `fuel`, `carPrice`, `availability`, `rentDate`, `returnDate`) VALUES
(1, 2, 'Ibraahim ilkacase', 'Sheikh-Ali', '3434343', 'Probox', 'White', 'Patrol', '89.99', 'Yes', '2024-01-05 04:47:18', '2024-01-09 04:47:18'),
(2, 4, 'Abdirisaaq', 'Nafaqada', '4343434', 'Toyota', 'Red', 'Patrol', '199.99', 'Yes', '2024-01-07 04:48:27', '2024-01-10 04:48:27'),
(3, 5, 'Ahmed Shaakir', 'Xalane', '787654', 'Noah', 'White', 'Patrol', '99.99', 'Yes', '2024-01-05 07:03:41', '2024-01-08 07:03:41'),
(4, 6, 'Sayid Mohamed', 'Taleex', '4798764', 'Bullut Proof', 'White', 'Patrol', '1289.99', 'Yes', '2024-01-05 07:08:02', '2024-01-24 07:08:02'),
(5, 7, 'Faarax Oomaar', 'JigJiga', '47837484', 'Surf', 'Black', 'Dissel', '88.99', 'Yes', '2024-01-05 07:11:57', '2024-01-10 07:11:57'),
(6, 8, 'Muuse Ali', 'Mudug', '7464733', 'BMW', 'BlueGrey', 'Patrol', '899.99', 'Yes', '2024-01-06 07:54:15', '2024-01-08 07:54:15');

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `id` int(11) NOT NULL,
  `name` varchar(200) DEFAULT NULL,
  `address` varchar(200) DEFAULT NULL,
  `email` varchar(200) DEFAULT NULL,
  `phone` varchar(200) DEFAULT NULL,
  `age` varchar(200) DEFAULT NULL,
  `std_class` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`id`, `name`, `address`, `email`, `phone`, `age`, `std_class`) VALUES
(2, 'Omar', 'Gaalkacyo', 'Omar@gmail.com', '5666656', '20', 'Fresh'),
(3, 'Abdirisaaq', 'Borama', 'Abdirisaq@gmail.com', '1223456', '30', 'Junior'),
(6, 'sdfsds', 'dsds', 'dsds', 'dsds', 'sddsd', 'dsdsd');

-- --------------------------------------------------------

--
-- Table structure for table `tblreturn`
--

CREATE TABLE `tblreturn` (
  `id` int(11) NOT NULL,
  `custName` varchar(200) DEFAULT NULL,
  `carBrand` varchar(200) DEFAULT NULL,
  `availability` varchar(200) DEFAULT NULL,
  `returnDate` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `days` varchar(200) DEFAULT NULL,
  `damage` varchar(200) DEFAULT NULL,
  `delay` varchar(200) DEFAULT NULL,
  `fine` varchar(200) DEFAULT NULL,
  `totalCost` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblreturn`
--

INSERT INTO `tblreturn` (`id`, `custName`, `carBrand`, `availability`, `returnDate`, `days`, `damage`, `delay`, `fine`, `totalCost`) VALUES
(1, 'Muuse Ali', 'BMW', 'Yes', '2024-01-12 08:08:39', '3', 'No', '4', '100', '3099.97');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `cars`
--
ALTER TABLE `cars`
  ADD PRIMARY KEY (`id`),
  ADD KEY `custID` (`custID`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`custID`);

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`custID`);

--
-- Indexes for table `rents`
--
ALTER TABLE `rents`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblreturn`
--
ALTER TABLE `tblreturn`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `cars`
--
ALTER TABLE `cars`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `custID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `rents`
--
ALTER TABLE `rents`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `students`
--
ALTER TABLE `students`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tblreturn`
--
ALTER TABLE `tblreturn`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `cars`
--
ALTER TABLE `cars`
  ADD CONSTRAINT `cars_ibfk_1` FOREIGN KEY (`custID`) REFERENCES `customers` (`custID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
