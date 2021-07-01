-- phpMyAdmin SQL Dump
-- version 3.4.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Oct 16, 2017 at 12:12 AM
-- Server version: 5.5.20
-- PHP Version: 5.3.10

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `thuoc_online`
--

-- --------------------------------------------------------

--
-- Table structure for table `thuoc`
--

CREATE TABLE IF NOT EXISTS `thuoc` (
  `mathuoc` int(11) NOT NULL AUTO_INCREMENT,
  `tenthuoc` varchar(50) NOT NULL,
  `giaban` float DEFAULT NULL,
  `soluong` int(11) DEFAULT NULL,
  `hinhanh` tinytext CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`mathuoc`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=12 ;

--
-- Dumping data for table `thuoc`
--

INSERT INTO `thuoc` (`mathuoc`, `tenthuoc`, `giaban`, `soluong`, `hinhanh`) VALUES
(1, 'Thuá»‘c trá»‹ Ä‘áº§y hÆ¡i air - X', 98000, 11, 'images/h1.jpg'),
(2, 'Nexium 40mg', 176000, 0, 'images/h2.jpg'),
(3, 'Hidrasec 10mg', 85000, 6, 'images/h3.jpg'),
(4, 'Meclopstad', 25000, 8, 'images/h4.jpg');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
