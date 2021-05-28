-- phpMyAdmin SQL Dump
-- version 3.4.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Oct 13, 2017 at 06:28 PM
-- Server version: 5.5.20
-- PHP Version: 5.3.10

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `hdthuoc`
--

-- --------------------------------------------------------

--
-- Table structure for table `thuoc`
--

CREATE TABLE IF NOT EXISTS `thuoc` (
  `mathuoc` int(11) NOT NULL AUTO_INCREMENT,
  `tenthuoc` varchar(50) NOT NULL,
  `hoatchat` varchar(50) NOT NULL,
  `dongia` float DEFAULT NULL,
  `soluong` int(11) DEFAULT NULL,
  PRIMARY KEY (`mathuoc`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=12 ;

--
-- Dumping data for table `thuoc`
--

INSERT INTO `thuoc` (`mathuoc`, `tenthuoc`, `hoatchat`, `dongia`, `soluong`) VALUES
(1, 'Atasic 200', 'Cefixim 200mg', 200, 200),
(2, 'Azicine ', 'Azithromycin dihydrate 250mg', 300, 20),
(3, 'Diamicron MR 30', 'Gliclazide 30mg.', 400, 270),
(4, 'Lomac-20', 'Omeprazole 20mg', 500, 40),
(5, 'Maxdotyl 50', 'Sulpirid 50mg', 600, 120),
(6, 'Medrol 16', 'Methylprednisolone 16mg', 700, 60);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
