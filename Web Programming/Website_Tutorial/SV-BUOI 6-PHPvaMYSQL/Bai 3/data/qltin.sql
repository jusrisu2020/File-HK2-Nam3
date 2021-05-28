-- phpMyAdmin SQL Dump
-- version 3.4.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Dec 05, 2013 at 02:48 AM
-- Server version: 5.5.20
-- PHP Version: 5.3.10

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `qltin`
--


-- --------------------------------------------------------

--
-- Table structure for table `baidang`
--

CREATE TABLE IF NOT EXISTS `baidang` (
  `maso` bigint(11) NOT NULL AUTO_INCREMENT,
  `chuyenmuc` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `noidung` text COLLATE utf8_unicode_ci NOT NULL,
  `diadiem` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`maso`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=6 ;

--
-- Dumping data for table `baidang`
--

INSERT INTO `baidang` (`maso`, `chuyenmuc`, `noidung`, `diadiem`, `email`) VALUES
(1, 'NhÃ  Ä‘áº¥t', '<p><b>Cáº§n ná»¯ á»Ÿ ghÃ©p Quáº­n 11 (gáº§n Äáº§m Sen)</b>\r\n<p>PhÃ²ng mÃ¬nh Ä‘ang cáº§n 1 báº¡n ná»¯ á»Ÿ ghÃ©p, phÃ²ng khÃ´ng chung chá»§ cÃ³ lá»‘i Ä‘i riÃªng tá»«ng phÃ²ng, rá»™ng rÃ£i, sáº¡ch sáº½, thoÃ¡ng mÃ¡t, an ninh gáº§n vÃ²ng xoay Äáº§m Sen, Ä‘á»ƒ xe miá»…n phÃ­, toilet riÃªng trong phÃ²ng. Äá»‘i diá»‡n cá»•ng chÃ­nh cÃ´ng viÃªn vÄƒn hÃ³a Äáº§m Sen.<br/>LiÃªn há»‡: 0979779754', 'ToÃ n quá»‘c', 'kenshin@hotmail.com'),
(2, 'MÃ¡y tÃ­nh', '<p><b>Mua 1 táº·ng 5. Giáº£m giÃ¡ 500.000 VNÄ - banlaptop.vn</b>\r\n<p>PhÃ¢n phá»‘i Netbook Atom cÅ©, Laptop Mini (Sony, Acer, Asus, Dell, HP, samsung...) cáº­p nháº­t tá»«ng ngÃ y, luÃ´n cÃ³ giÃ¡ tá»‘t cho anh em ká»¹ thuáº­t, Vui lÃ²ng liÃªn há»‡ hoáº·c Ä‘iá»‡n thoáº¡i trá»±c tiáº¿p sáº½ cÃ³ giÃ¡ tá»‘t nháº¥t.<br/>Äiá»‡n thoáº¡i: (08) 3869.1583', 'TP. Há»“ ChÃ­ Minh', 'netbooksvn@yahoo.com'),
(3, 'Äiá»‡n thoáº¡i', '<p><b>BÃ¡n samsung galaxy s4 i9500 16gb (tráº¯ng)</b>\r\n<p>MÃ¬nh Ä‘ang cÃ³ nhu cáº§u cáº§n bÃ¡n 1 mÃ¡y Samsung Galaxy S4 I9505 16Gb, chÃ­nh hÃ£ng, mÃ u tráº¯ng, chÆ°a bung chÆ°a sá»­a chá»¯a hay thay tháº¿ gÃ¬ háº¿t nha. MÃ¡y cÃ²n má»›i 95% á»•n Ä‘á»‹nh khÃ´ng cÃ³ báº¥t kÃ¬ trá»¥c tráº·c gÃ¬.. Phá»¥ kiá»‡n theo mÃ¡y gá»“m: sáº¡c, cÃ¡p usb, tai nghe. GiÃ¡  8 triá»‡u. <br/>LiÃªn há»‡ 0967 320 640 (Tháº£o) ', 'ToÃ n quá»‘c', 'jully_thao@gmail.com'),
(4, 'Ã” tÃ´ - Xe mÃ¡y', '<p><b>BÃ¡n xe mÃ¡y Jupiter MX cÃ²n má»›i 95%</b> \r\n<p>ChÃ­nh chá»§ cáº§n bÃ¡n 1 xe mÃ¡y Jupiter MX mÃ u Ä‘en Ä‘á», phanh Ä‘Ä©a, má»›i mua 10/2012. Xe má»›i Ä‘i Ä‘Æ°á»£c gáº§n 5,000km, cÃ²n ráº¥t má»›i, trong thá»i gian báº£o hÃ nh.\r\nGiÃ¡ bÃ¡n 19tr. <br/>\r\n\r\nLiÃªn há»‡ chá»‹ Nhung 0945045858', 'ToÃ n quá»‘c', 'nhung_dothituyet@yahoo.com');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
