-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 20, 2018 at 06:53 AM
-- Server version: 10.1.26-MariaDB
-- PHP Version: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `posdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `cash_book`
--

CREATE TABLE `cash_book` (
  `counter_id` char(100) NOT NULL,
  `bill_no` char(100) NOT NULL,
  `date` date NOT NULL,
  `discount_price` char(100) NOT NULL,
  `expences` char(100) NOT NULL,
  `income` char(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `category_name` char(100) NOT NULL,
  `cotegory_id` char(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`category_name`, `cotegory_id`) VALUES
('kiri piti', '10');

-- --------------------------------------------------------

--
-- Table structure for table `company`
--

CREATE TABLE `company` (
  `company_name` char(100) NOT NULL,
  `company_address` char(100) NOT NULL,
  `company_phone_no` char(30) NOT NULL,
  `company_id` char(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `company`
--

INSERT INTO `company` (`company_name`, `company_address`, `company_phone_no`, `company_id`) VALUES
('redbull', 'colombo', '123', '1'),
('a', 'a', 'a', '10'),
('anchor', 'kk', '123', '11'),
('prima', 'kkk', '12345', '12'),
('uniliver', 'kk', '12345', '8'),
('pelvaththa', 'a', 'a', '9');

-- --------------------------------------------------------

--
-- Table structure for table `counter`
--

CREATE TABLE `counter` (
  `counter_name` char(100) NOT NULL,
  `location` char(100) NOT NULL,
  `counter_id` char(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `issue`
--

CREATE TABLE `issue` (
  `bill_no` char(100) NOT NULL,
  `date` date NOT NULL,
  `user_id` int(100) NOT NULL,
  `barcode` char(100) NOT NULL,
  `quantity` char(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `product_id` char(100) NOT NULL,
  `barcode` char(100) NOT NULL,
  `get_price` char(100) NOT NULL,
  `exp_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `product_details`
--

CREATE TABLE `product_details` (
  `company_id` char(100) NOT NULL,
  `cotegory_id` char(100) NOT NULL,
  `product_name` char(100) NOT NULL,
  `product_id` char(100) NOT NULL,
  `minimum_quantity` char(100) NOT NULL,
  `sell_price` char(100) NOT NULL,
  `product_discount_price` char(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `stock`
--

CREATE TABLE `stock` (
  `barcode` char(100) NOT NULL,
  `stock_date` date NOT NULL,
  `invoice_number` char(100) NOT NULL,
  `start_quantity` char(100) NOT NULL,
  `current_quantity` char(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `user_name` char(100) NOT NULL,
  `password` char(100) NOT NULL,
  `type` char(100) NOT NULL,
  `user_id` char(100) NOT NULL,
  `counter_id` char(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_name`, `password`, `type`, `user_id`, `counter_id`) VALUES
('dhanushka', '1234', 'manager', '1', '1');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cash_book`
--
ALTER TABLE `cash_book`
  ADD PRIMARY KEY (`bill_no`,`counter_id`,`date`);

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`cotegory_id`);

--
-- Indexes for table `company`
--
ALTER TABLE `company`
  ADD PRIMARY KEY (`company_id`);

--
-- Indexes for table `counter`
--
ALTER TABLE `counter`
  ADD PRIMARY KEY (`counter_id`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`barcode`);

--
-- Indexes for table `product_details`
--
ALTER TABLE `product_details`
  ADD PRIMARY KEY (`product_id`);

--
-- Indexes for table `stock`
--
ALTER TABLE `stock`
  ADD PRIMARY KEY (`barcode`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
