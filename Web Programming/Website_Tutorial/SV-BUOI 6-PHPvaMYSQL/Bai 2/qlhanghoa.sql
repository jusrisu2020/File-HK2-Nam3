-- phpMyAdmin SQL Dump
-- version 4.0.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Nov 12, 2015 at 03:56 AM
-- Server version: 5.5.34
-- PHP Version: 5.3.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `qlhanghoa`
--
CREATE DATABASE IF NOT EXISTS `qlhanghoa` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE `qlhanghoa`;

-- --------------------------------------------------------

--
-- Table structure for table `mathang`
--

CREATE TABLE IF NOT EXISTS `mathang` (
  `MaHang` varchar(20) COLLATE utf8_unicode_ci NOT NULL DEFAULT '',
  `TenHang` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `GiaGoc` bigint(20) NOT NULL,
  `GiaBan` bigint(20) NOT NULL,
  `HinhAnh` tinytext COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`MaHang`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `mathang`
--

INSERT INTO `mathang` (`MaHang`, `TenHang`, `GiaGoc`, `GiaBan`, `HinhAnh`) VALUES
('CANON POWERSHOT A250', 'MÃY áº¢NH CANON POWERSHOT A2500', 2990000, 2090000, 'image/canon.png'),
('PANASONIC TH-L50B60V', 'TIVI LED PANASONIC TH-L50B60V', 18490000, 16690000, 'image/pana.jpg'),
('RINNAI RV-367(S)N', 'Báº¾P GAS RINNAI RV-367(S)N', 1035000, 879000, 'image/rinnai.jpg'),
('Sony Vaio SVF14217SG', 'Laptop Sony Vaio SVF14217SG-B', 16990000, 14990000, 'image/vaio.jpg'),
('Sony Xperia Z C6602', 'Äiá»‡n thoáº¡i Sony Xperia Z C6602', 15490000, 14490000, 'image/xperia.jpg'),
('TOSHIBA GR-S21VPB DS', 'Tá»¦ Láº NH TOSHIBA 186 LIT GR-S21VPB(DS)', 7200000, 6399000, 'image/toshiba.jpg');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
