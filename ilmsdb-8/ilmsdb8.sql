-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 03, 2018 at 08:23 AM
-- Server version: 10.1.26-MariaDB
-- PHP Version: 7.1.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ilmsdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `course`
--

CREATE TABLE `course` (
  `COURSE_ID` int(11) NOT NULL,
  `COURSE_NAME` varchar(30) NOT NULL,
  `COURSE_LEVEL` int(11) NOT NULL DEFAULT '1',
  `COURSE_MAJOR` varchar(30) NOT NULL DEFAULT 'None',
  `COURSE_DESC` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `course`
--

INSERT INTO `course` (`COURSE_ID`, `COURSE_NAME`, `COURSE_LEVEL`, `COURSE_MAJOR`, `COURSE_DESC`) VALUES
(1, 'BSCS', 1, '', 'Bachelor of Science In Computer Science'),
(2, 'BSCS', 2, '', 'BACHELOR OF SCIENCE IN COMPUTER SCIENCE'),
(3, 'BSCS', 3, '', 'BACHELOR OF SCIENCE IN COMPUTER SCIENCE'),
(4, 'BSCS', 4, '', 'BACHELOR OF SCIENCE IN COMPUTER SCIENCE'),
(5, 'BSA', 1, '', 'BACHELOR OF SCIENCE IN ACCOUNTANCY'),
(6, 'BSA', 2, '', 'BACHELOR OF SCIENCE IN ACCOUNTANCY'),
(7, 'BSA', 3, '', 'BACHELOR OF SCIENCE IN ACCOUNTANCY'),
(8, 'BSA', 4, '', 'BACHELOR OF SCIENCE IN ACCOUNTANCY'),
(9, 'BSBA', 1, 'FINANCIAL MANAGEMENT', 'BACHELOR OF SCIENCE IN BUSINESS ADMINISTRATION'),
(10, 'BSBA', 2, 'FINANCIAL MANAGEMENT', 'BACHELOR OF SCIENCE IN BUSINESS ADMINISTRATION'),
(11, 'BSBA', 3, 'FINANCIAL MANAGEMENT', 'BACHELOR OF SCIENCE IN BUSINESS ADMINISTRATION'),
(12, 'BSBA', 4, 'FINANCIAL MANAGEMENT', 'BACHELOR OF SCIENCE IN BUSINESS ADMINISTRATION'),
(13, 'BEED', 1, '', 'BACHELOR OF ELEMENTARY EDUCATION'),
(14, 'BEED', 2, '', 'BACHELOR OF ELEMENTARY EDUCATION'),
(15, 'BEED', 3, '', 'BACHELOR OF ELEMENTARY EDUCATION'),
(16, 'BEED', 4, '', 'BACHELOR OF ELEMENTARY EDUCATION'),
(17, 'ACT', 1, '', 'ACT');

-- --------------------------------------------------------

--
-- Table structure for table `tblcommon_list`
--

CREATE TABLE `tblcommon_list` (
  `COMMON_ID` int(11) NOT NULL,
  `COMMON_CODE` varchar(30) NOT NULL,
  `CATEGORY` varchar(30) NOT NULL,
  `LISTNAME` varchar(30) NOT NULL,
  `ISDEFAULT` varchar(10) NOT NULL DEFAULT 'No'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblcommon_list`
--

INSERT INTO `tblcommon_list` (`COMMON_ID`, `COMMON_CODE`, `CATEGORY`, `LISTNAME`, `ISDEFAULT`) VALUES
(1, 'AY2017-2018', 'AY', '2017-2018', 'NO'),
(2, 'AY2018-2019', 'AY', '2018-2019', 'YES'),
(5, 'SEMESTERFIRST', 'SEMESTER', 'FIRST', 'NO'),
(6, 'SEMESTERSECOND', 'SEMESTER', 'SECOND', 'YES'),
(7, 'semestersummer', 'semester', 'summer', 'NO');

-- --------------------------------------------------------

--
-- Table structure for table `tbldefaulttime`
--

CREATE TABLE `tbldefaulttime` (
  `TIMEID` int(11) NOT NULL,
  `ALLOTEDTIME` time NOT NULL,
  `ISDEFAULT` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbldefaulttime`
--

INSERT INTO `tbldefaulttime` (`TIMEID`, `ALLOTEDTIME`, `ISDEFAULT`) VALUES
(1, '00:00:00', 'NO'),
(2, '10:00:00', 'YES'),
(3, '11:00:00', 'NO'),
(4, '12:00:00', 'NO'),
(5, '15:00:00', 'NO'),
(6, '16:00:00', 'NO'),
(7, '17:00:00', 'NO');

-- --------------------------------------------------------

--
-- Table structure for table `tblenrollment`
--

CREATE TABLE `tblenrollment` (
  `ENROLLMENTID` int(11) NOT NULL,
  `STUDENTNAME` varchar(50) NOT NULL,
  `STUDENTID` varchar(20) NOT NULL,
  `COURSE` varchar(30) NOT NULL,
  `YEARLEVEL` varchar(30) NOT NULL,
  `SEMESTER` varchar(30) NOT NULL,
  `AY` varchar(30) NOT NULL,
  `TIMEALLOTED` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblenrollment`
--

INSERT INTO `tblenrollment` (`ENROLLMENTID`, `STUDENTNAME`, `STUDENTID`, `COURSE`, `YEARLEVEL`, `SEMESTER`, `AY`, `TIMEALLOTED`) VALUES
(15, 'Melchor, John Luis', '20140032', 'BSCS', '4', 'SECOND', '2018-2019', '09:58:09'),
(16, 'Dela Cruz, John Clyde', '20140031', 'BSCS', '4', 'SECOND', '2018-2019', '09:59:38'),
(17, 'macaraeg, von', '1234', 'BSCS', '4', 'SECOND', '2018-2019', '11:59:55'),
(18, 'gabatino, justine', '1235', 'BSCS', '4', 'SECOND', '2018-2019', '00:00:00'),
(19, 'cortez, roel p', '225', 'BSCS', '4', 'SECOND', '2018-2019', '00:00:00'),
(20, 'arciaga, estrelito', '123', 'BSCS', '4', 'SECOND', '2018-2019', '09:58:16'),
(22, 'Dela Cruz, Juan', '321', 'BSCS', '4', 'SECOND', '2018-2019', '09:57:32'),
(23, 'cortez, roel', '225', 'BSCS', '4', 'SECOND', '2018-2019', '10:00:00'),
(24, 'm, joy', '1233', 'BSCS', '4', 'SECOND', '2018-2019', '09:59:53'),
(25, 'len, lan', '3333', 'BSCS', '4', 'SECOND', '2018-2019', '09:56:14'),
(26, 'Cruz, John', '4444', 'BSCS', '4', 'SECOND', '2018-2019', '09:43:10'),
(27, 'Palma, Edsel', '54321', 'ACT', '1', 'SECOND', '2018-2019', '09:58:46');

-- --------------------------------------------------------

--
-- Table structure for table `tblitem`
--

CREATE TABLE `tblitem` (
  `ITEMID` int(11) NOT NULL,
  `ITEMNAME` varchar(50) NOT NULL,
  `ITEMCOLOR` varchar(60) NOT NULL,
  `ITEMBRAND` varchar(60) NOT NULL,
  `ITEMDESC` text NOT NULL,
  `REMARKS` text NOT NULL,
  `ITEMSTATUS` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblstudent`
--

CREATE TABLE `tblstudent` (
  `S_ID` int(11) NOT NULL,
  `IDNO` int(20) NOT NULL,
  `FNAME` varchar(40) NOT NULL,
  `LNAME` varchar(40) NOT NULL,
  `MNAME` varchar(40) NOT NULL,
  `GENDER` varchar(10) NOT NULL DEFAULT 'Male',
  `BDAY` date NOT NULL,
  `AGE` int(30) NOT NULL,
  `CONTACT_NO` varchar(40) NOT NULL,
  `HOME_ADD` text NOT NULL,
  `EMAIL` varchar(255) NOT NULL,
  `ACC_PASSWORD` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstudent`
--

INSERT INTO `tblstudent` (`S_ID`, `IDNO`, `FNAME`, `LNAME`, `MNAME`, `GENDER`, `BDAY`, `AGE`, `CONTACT_NO`, `HOME_ADD`, `EMAIL`, `ACC_PASSWORD`) VALUES
(13, 20140032, 'John Luis', 'Melchor', 'Medrano', 'Male', '0000-00-00', 0, '', '', '', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(14, 20140031, 'John Clyde', 'Dela Cruz', 'Carlos', 'Male', '0000-00-00', 0, '', '', '', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(15, 1234, 'von', 'macaraeg', 'm', 'Male', '0000-00-00', 0, '', '', '', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(16, 1235, 'justine', 'gabatino', 'g', 'Male', '0000-00-00', 0, '', '', '', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(17, 225, 'roel', 'cortez', 'p', 'Male', '0000-00-00', 0, '', '', '', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(18, 123, 'estrelito', 'arciaga', 'd', 'Male', '0000-00-00', 0, '', '', '', 'd86caede0264d429ed6b1d3fe83ec87a18eed990'),
(20, 321, 'Juan', 'Dela Cruz', 'D', 'Male', '0000-00-00', 0, '', '', '', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(21, 234, 'bryan', 'reyes', 'p', 'Male', '0000-00-00', 0, '', '', '', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(22, 1233, 'joy', 'm', 'dizon', 'Male', '0000-00-00', 0, '', '', '', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(23, 3333, 'lan', 'len', 'lin', 'Male', '0000-00-00', 0, '', '', '', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(24, 4444, 'John', 'Cruz', 'D', 'Male', '0000-00-00', 0, '', '', '', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220'),
(25, 54321, 'Edsel', 'Palma', 'O', 'Male', '0000-00-00', 0, '', '', '', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220');

-- --------------------------------------------------------

--
-- Table structure for table `tbltimelogs`
--

CREATE TABLE `tbltimelogs` (
  `LOGID` int(11) NOT NULL,
  `LAST_LOGINDATE` date NOT NULL,
  `LAST_LOGINTIME` time NOT NULL,
  `TIMESTART` time NOT NULL,
  `TIMEEND` time NOT NULL,
  `IDNUM` varchar(30) NOT NULL,
  `ACTIVESTATUS` varchar(10) NOT NULL DEFAULT 'NOT ACTIVE'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbltimelogs`
--

INSERT INTO `tbltimelogs` (`LOGID`, `LAST_LOGINDATE`, `LAST_LOGINTIME`, `TIMESTART`, `TIMEEND`, `IDNUM`, `ACTIVESTATUS`) VALUES
(1, '0000-00-00', '06:40:00', '09:38:22', '09:37:57', '1234', 'NOT ACTIVE'),
(2, '0000-00-00', '06:54:00', '09:37:57', '00:00:00', '1234', 'NOT ACTIVE'),
(3, '2018-01-13', '02:43:00', '10:00:00', '00:00:00', '12334', 'NOTACTIVE'),
(4, '2018-01-13', '02:45:00', '00:00:00', '00:00:00', '12334', 'NOTACTIVE'),
(5, '2018-01-13', '02:45:00', '00:00:00', '00:00:00', '12334', 'NOTACTIVE'),
(6, '2018-01-13', '02:47:00', '00:00:00', '00:00:00', '12334', 'NOTACTIVE'),
(7, '2018-01-13', '03:03:00', '00:00:00', '00:00:00', '3210', 'NOTACTIVE'),
(8, '2018-01-13', '03:05:00', '09:37:57', '00:00:00', '1234', 'NOTACTIVE'),
(9, '2018-01-13', '03:35:00', '10:00:00', '00:00:00', '1111', 'NOTACTIVE'),
(10, '2018-01-13', '03:36:00', '00:00:00', '00:00:00', '1111', 'NOTACTIVE'),
(11, '2018-01-13', '03:37:00', '00:00:00', '00:00:00', '1111', 'NOTACTIVE'),
(12, '2018-01-13', '07:44:00', '00:00:00', '00:00:00', '3210', 'NOTACTIVE'),
(13, '2018-01-13', '07:45:00', '00:00:00', '00:00:00', '3210', 'ACTIVE'),
(14, '2018-01-13', '07:45:00', '10:00:00', '00:00:00', '1111', 'NOTACTIVE'),
(15, '2018-01-17', '05:25:00', '10:00:00', '00:00:00', '2222', 'NOTACTIVE'),
(16, '2018-01-17', '05:27:00', '00:00:00', '00:00:00', '2222', 'NOTACTIVE'),
(17, '2018-01-17', '06:05:00', '10:00:00', '00:00:00', '1111', 'NOTACTIVE'),
(18, '2018-01-17', '06:06:00', '00:00:00', '00:00:00', '1111', 'NOTACTIVE'),
(19, '2018-01-18', '10:27:00', '10:00:00', '00:00:00', '2222', 'NOTACTIVE'),
(20, '2018-01-18', '10:28:00', '00:00:00', '00:00:00', '2222', 'NOTACTIVE'),
(21, '2018-01-18', '10:32:00', '00:00:00', '00:00:00', '2222', 'NOTACTIVE'),
(22, '2018-01-18', '10:37:00', '10:00:00', '00:00:00', '3333', 'NOTACTIVE'),
(23, '2018-01-18', '10:38:00', '10:00:00', '00:00:00', '3333', 'NOTACTIVE'),
(24, '2018-01-18', '10:39:00', '10:00:00', '00:00:00', '3333', 'NOTACTIVE'),
(25, '2018-01-18', '10:41:00', '10:00:00', '00:00:00', '1111', 'NOTACTIVE'),
(26, '2018-01-18', '10:41:00', '00:00:00', '00:00:00', '1111', 'NOTACTIVE'),
(27, '2018-01-18', '02:44:00', '10:00:00', '00:00:00', '4444', 'NOTACTIVE'),
(28, '2018-01-18', '02:52:00', '00:00:00', '00:00:00', '4444', 'NOTACTIVE'),
(29, '2018-01-18', '03:02:00', '10:00:00', '00:00:00', '5555', 'NOTACTIVE'),
(30, '2018-02-24', '02:08:00', '10:00:00', '09:59:47', '20140031', 'NOTACTIVE'),
(31, '2018-02-24', '02:09:00', '09:59:47', '09:59:38', '20140031', 'NOTACTIVE'),
(32, '2018-02-24', '02:15:00', '12:00:00', '11:59:55', '1234', 'NOTACTIVE'),
(33, '2018-02-24', '02:19:00', '00:00:00', '00:00:00', '1235', 'NOTACTIVE'),
(34, '2018-03-01', '10:45:00', '00:00:00', '00:00:00', '225', 'NOTACTIVE'),
(35, '2018-03-01', '10:47:00', '00:00:00', '00:00:00', '225', 'NOTACTIVE'),
(36, '2018-03-01', '10:53:00', '10:00:00', '09:59:50', '123', 'NOTACTIVE'),
(37, '2018-03-01', '10:58:00', '09:59:50', '09:59:15', '123', 'NOTACTIVE'),
(38, '2018-03-02', '05:18:00', '09:59:15', '09:58:54', '123', 'NOTACTIVE'),
(39, '2018-03-02', '05:19:00', '09:58:54', '09:58:16', '123', 'NOTACTIVE'),
(40, '2018-03-02', '05:24:00', '00:00:00', '00:00:00', '225', 'NOTACTIVE'),
(41, '2018-03-02', '09:20:00', '10:00:00', '09:59:45', '20140032', 'NOTACTIVE'),
(42, '2018-03-02', '09:21:00', '09:59:45', '09:59:35', '20140032', 'NOTACTIVE'),
(43, '2018-03-02', '09:23:00', '09:59:35', '09:59:13', '20140032', 'NOTACTIVE'),
(44, '2018-03-03', '06:36:00', '09:59:13', '09:58:27', '20140032', 'NOTACTIVE'),
(45, '2018-03-03', '08:05:00', '09:58:27', '09:58:09', '20140032', 'NOTACTIVE'),
(46, '2018-03-03', '08:40:00', '10:00:00', '09:59:56', '321', 'NOTACTIVE'),
(47, '2018-03-03', '08:55:00', '09:59:56', '09:59:22', '321', 'NOTACTIVE'),
(48, '2018-03-03', '08:57:00', '09:59:22', '09:59:16', '321', 'NOTACTIVE'),
(49, '2018-03-03', '08:57:00', '09:59:16', '09:58:58', '321', 'NOTACTIVE'),
(50, '2018-03-03', '09:31:00', '00:00:00', '00:00:00', '321', 'NOTACTIVE'),
(51, '2018-03-03', '09:31:00', '00:00:00', '00:00:00', '20140032', 'NOTACTIVE'),
(52, '2018-03-03', '09:34:00', '00:00:00', '00:00:00', '1235', 'NOTACTIVE'),
(53, '2018-03-03', '09:36:00', '00:00:00', '00:00:00', '234', 'NOTACTIVE'),
(54, '2018-03-03', '09:37:00', '10:00:00', '09:59:35', '322', 'NOTACTIVE'),
(55, '2018-03-03', '09:42:00', '09:59:35', '00:00:00', '322', 'ACTIVE'),
(56, '2018-03-03', '09:42:00', '09:59:35', '00:00:00', '322', 'ACTIVE'),
(57, '2018-03-03', '11:30:00', '10:00:00', '09:59:53', '1233', 'NOTACTIVE'),
(58, '2018-03-08', '09:20:00', '09:58:58', '09:58:51', '321', 'NOTACTIVE'),
(59, '2018-03-08', '09:21:00', '09:58:51', '09:58:42', '321', 'NOTACTIVE'),
(60, '2018-03-08', '09:22:00', '09:58:42', '09:58:21', '321', 'NOTACTIVE'),
(61, '2018-03-08', '09:22:00', '09:58:21', '09:58:04', '321', 'NOTACTIVE'),
(62, '2018-03-08', '09:23:00', '09:58:04', '09:57:51', '321', 'NOTACTIVE'),
(63, '2018-03-08', '09:25:00', '10:00:00', '09:56:51', '3333', 'NOTACTIVE'),
(64, '2018-03-08', '09:28:00', '09:56:51', '09:56:44', '3333', 'NOTACTIVE'),
(65, '2018-03-08', '09:28:00', '09:56:44', '09:56:22', '3333', 'NOTACTIVE'),
(66, '2018-03-08', '11:09:00', '09:56:22', '09:56:14', '3333', 'NOTACTIVE'),
(67, '2018-03-08', '11:11:00', '10:00:00', '09:59:41', '4444', 'NOTACTIVE'),
(68, '2018-03-08', '11:14:00', '09:59:41', '09:59:31', '4444', 'NOTACTIVE'),
(69, '2018-03-08', '11:15:00', '09:59:31', '09:58:32', '4444', 'NOTACTIVE'),
(70, '2018-03-08', '11:18:00', '09:58:32', '09:58:15', '4444', 'NOTACTIVE'),
(71, '2018-03-08', '11:19:00', '09:58:15', '09:58:02', '4444', 'NOTACTIVE'),
(72, '2018-03-08', '11:22:00', '09:58:02', '09:57:43', '4444', 'NOTACTIVE'),
(73, '2018-03-08', '11:26:00', '09:57:43', '09:56:40', '4444', 'NOTACTIVE'),
(74, '2018-03-08', '11:28:00', '09:56:40', '09:56:02', '4444', 'NOTACTIVE'),
(75, '2018-03-08', '11:28:00', '09:56:02', '09:55:58', '4444', 'NOTACTIVE'),
(76, '2018-03-08', '11:30:00', '09:55:58', '09:55:51', '4444', 'NOTACTIVE'),
(77, '2018-03-08', '11:30:00', '09:55:51', '09:55:46', '4444', 'NOTACTIVE'),
(78, '2018-03-08', '11:33:00', '09:55:46', '00:00:00', '4444', 'ACTIVE'),
(79, '2018-03-08', '11:35:00', '09:55:46', '09:52:52', '4444', 'NOTACTIVE'),
(80, '2018-03-08', '11:41:00', '09:52:52', '09:52:07', '4444', 'NOTACTIVE'),
(81, '2018-03-08', '11:44:00', '09:52:07', '09:51:27', '4444', 'NOTACTIVE'),
(82, '2018-03-08', '11:46:00', '09:51:27', '09:51:11', '4444', 'NOTACTIVE'),
(83, '2018-03-08', '11:48:00', '09:51:11', '09:50:45', '4444', 'NOTACTIVE'),
(84, '2018-03-08', '11:49:00', '09:50:45', '09:50:40', '4444', 'NOTACTIVE'),
(85, '2018-03-08', '11:50:00', '09:50:40', '00:00:00', '4444', 'ACTIVE'),
(86, '2018-03-08', '11:54:00', '09:50:40', '09:50:34', '4444', 'NOTACTIVE'),
(87, '2018-03-08', '11:55:00', '09:50:34', '00:00:00', '4444', 'ACTIVE'),
(88, '2018-03-08', '11:58:00', '09:50:34', '09:48:40', '4444', 'NOTACTIVE'),
(89, '2018-03-08', '11:59:00', '09:48:40', '00:00:00', '4444', 'ACTIVE'),
(90, '2018-03-08', '12:00:00', '09:48:40', '09:48:05', '4444', 'NOTACTIVE'),
(91, '2018-03-08', '12:03:00', '09:48:05', '09:48:01', '4444', 'NOTACTIVE'),
(92, '2018-03-08', '12:04:00', '09:48:01', '09:47:29', '4444', 'NOTACTIVE'),
(93, '2018-03-08', '12:05:00', '09:57:51', '09:57:47', '321', 'NOTACTIVE'),
(94, '2018-03-08', '12:08:00', '09:47:29', '09:47:14', '4444', 'NOTACTIVE'),
(95, '2018-03-08', '12:08:00', '09:47:14', '09:47:11', '4444', 'NOTACTIVE'),
(96, '2018-03-08', '12:09:00', '09:47:11', '00:00:00', '4444', 'ACTIVE'),
(97, '2018-03-08', '12:12:00', '09:47:11', '00:00:00', '4444', 'ACTIVE'),
(98, '2018-03-08', '12:13:00', '09:47:11', '09:45:08', '4444', 'NOTACTIVE'),
(99, '2018-03-08', '12:14:00', '09:45:08', '09:45:04', '4444', 'NOTACTIVE'),
(100, '2018-03-08', '01:12:00', '09:45:04', '09:44:37', '4444', 'NOTACTIVE'),
(101, '2018-03-08', '01:13:00', '09:44:37', '09:44:04', '4444', 'NOTACTIVE'),
(102, '2018-03-08', '01:24:00', '09:44:04', '09:43:46', '4444', 'NOTACTIVE'),
(103, '2018-03-08', '01:25:00', '09:43:46', '09:43:10', '4444', 'NOTACTIVE'),
(104, '2018-03-08', '01:26:00', '09:43:10', '00:00:00', '4444', 'ACTIVE'),
(105, '2018-03-08', '01:27:00', '09:57:47', '09:57:32', '321', 'NOTACTIVE'),
(106, '2018-03-08', '01:27:00', '09:57:32', '00:00:00', '321', 'ACTIVE'),
(107, '2018-03-08', '01:27:00', '09:57:32', '00:00:00', '321', 'ACTIVE'),
(108, '2018-04-03', '01:32:00', '10:00:00', '09:58:46', '54321', 'NOTACTIVE'),
(109, '2018-04-03', '01:57:00', '09:58:46', '00:00:00', '54321', 'ACTIVE');

-- --------------------------------------------------------

--
-- Table structure for table `useraccounts`
--

CREATE TABLE `useraccounts` (
  `ACCOUNT_ID` int(11) NOT NULL,
  `ACCOUNT_NAME` varchar(255) NOT NULL,
  `ACCOUNT_USERNAME` varchar(255) NOT NULL,
  `ACCOUNT_PASSWORD` text NOT NULL,
  `ACCOUNT_TYPE` varchar(30) NOT NULL,
  `EMPID` int(11) NOT NULL,
  `ACC_STATUS` varchar(10) NOT NULL DEFAULT 'ACTIVE'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `useraccounts`
--

INSERT INTO `useraccounts` (`ACCOUNT_ID`, `ACCOUNT_NAME`, `ACCOUNT_USERNAME`, `ACCOUNT_PASSWORD`, `ACCOUNT_TYPE`, `EMPID`, `ACC_STATUS`) VALUES
(1, 'Administrator', 'admin', '5c2dd944dde9e08881bef0894fe7b22a5c9c4b06', 'Administrator', 123, ''),
(23, 'Melchor John Luis Medrano', '20140032', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220', 'Student', 20140032, 'ACTIVE'),
(24, 'Dela Cruz John Clyde Carlos', '20140031', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220', 'Student', 20140031, 'ACTIVE'),
(25, 'jamie', 'librarian', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220', 'Librarian', 0, 'ACTIVE'),
(26, 'macaraeg von m', '1234', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220', 'Student', 1234, 'ACTIVE'),
(27, 'gabatino justine g', '1235', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220', 'Student', 1235, 'ACTIVE'),
(28, 'cortez, roel p', 'cortezroel', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220', 'Student', 225, 'ACTIVE'),
(29, 'arciaga estrelito d', 'ace', 'd86caede0264d429ed6b1d3fe83ec87a18eed990', 'Student', 123, 'ACTIVE'),
(31, 'Dela Cruz Juan D', '321', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220', 'Student', 321, 'ACTIVE'),
(32, 'reyes bryan p', '234', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220', 'Student', 234, 'ACTIVE'),
(33, 'm joy dizon', '1233', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220', 'Student', 1233, 'ACTIVE'),
(34, 'len lan lin', '3333', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220', 'Student', 3333, 'ACTIVE'),
(35, 'Cruz John D', '4444', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220', 'Student', 4444, 'ACTIVE'),
(36, 'Palma Edsel O', 'edsel', '7110eda4d09e062aa5e4a390b0a572ac0d2c0220', 'Student', 54321, 'ACTIVE');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`COURSE_ID`);

--
-- Indexes for table `tblcommon_list`
--
ALTER TABLE `tblcommon_list`
  ADD PRIMARY KEY (`COMMON_ID`);

--
-- Indexes for table `tbldefaulttime`
--
ALTER TABLE `tbldefaulttime`
  ADD PRIMARY KEY (`TIMEID`);

--
-- Indexes for table `tblenrollment`
--
ALTER TABLE `tblenrollment`
  ADD PRIMARY KEY (`ENROLLMENTID`);

--
-- Indexes for table `tblitem`
--
ALTER TABLE `tblitem`
  ADD PRIMARY KEY (`ITEMID`);

--
-- Indexes for table `tblstudent`
--
ALTER TABLE `tblstudent`
  ADD PRIMARY KEY (`S_ID`);

--
-- Indexes for table `tbltimelogs`
--
ALTER TABLE `tbltimelogs`
  ADD PRIMARY KEY (`LOGID`);

--
-- Indexes for table `useraccounts`
--
ALTER TABLE `useraccounts`
  ADD PRIMARY KEY (`ACCOUNT_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `course`
--
ALTER TABLE `course`
  MODIFY `COURSE_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
--
-- AUTO_INCREMENT for table `tblcommon_list`
--
ALTER TABLE `tblcommon_list`
  MODIFY `COMMON_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `tbldefaulttime`
--
ALTER TABLE `tbldefaulttime`
  MODIFY `TIMEID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `tblenrollment`
--
ALTER TABLE `tblenrollment`
  MODIFY `ENROLLMENTID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;
--
-- AUTO_INCREMENT for table `tblitem`
--
ALTER TABLE `tblitem`
  MODIFY `ITEMID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tblstudent`
--
ALTER TABLE `tblstudent`
  MODIFY `S_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
--
-- AUTO_INCREMENT for table `tbltimelogs`
--
ALTER TABLE `tbltimelogs`
  MODIFY `LOGID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=110;
--
-- AUTO_INCREMENT for table `useraccounts`
--
ALTER TABLE `useraccounts`
  MODIFY `ACCOUNT_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
