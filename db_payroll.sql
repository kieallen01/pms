/*
MySQL Data Transfer
Source Host: localhost
Source Database: db_payroll
Target Host: localhost
Target Database: db_payroll
Date: 9/25/2016 7:27:12 AM
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for tbl_employee
-- ----------------------------
CREATE TABLE `tbl_employee` (
  `emp_id` varchar(10) DEFAULT NULL,
  `fullname` varchar(50) DEFAULT NULL,
  `address` varchar(60) DEFAULT NULL,
  `phone_number` varchar(15) DEFAULT NULL,
  `email` varchar(40) DEFAULT NULL,
  `dateofbirth` varchar(20) DEFAULT NULL,
  `age` varchar(2) DEFAULT NULL,
  `placeofbirth` varchar(60) DEFAULT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `civilstatus` varchar(10) DEFAULT NULL,
  `datestarted` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Table structure for tbl_payroll
-- ----------------------------
CREATE TABLE `tbl_payroll` (
  `employee_id` varchar(20) DEFAULT NULL,
  `employee_name` varchar(50) DEFAULT NULL,
  `dailyrate` varchar(4) DEFAULT NULL,
  `days_work` varchar(2) DEFAULT NULL,
  `days_absent` varchar(2) DEFAULT NULL,
  `days_ot` varchar(2) DEFAULT NULL,
  `otpay` varchar(10) DEFAULT NULL,
  `sss` varchar(3) DEFAULT NULL,
  `whtax` varchar(3) DEFAULT NULL,
  `ph` varchar(3) DEFAULT NULL,
  `absent_deductions` varchar(10) DEFAULT NULL,
  `loans` varchar(3) DEFAULT NULL,
  `total_deductions` varchar(5) DEFAULT NULL,
  `total_sallary` varchar(10) DEFAULT NULL,
  `netpay` varchar(10) DEFAULT NULL,
  `datefrom` varchar(30) DEFAULT NULL,
  `dateto` varchar(30) DEFAULT NULL,
  `date_release` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Table structure for tbl_usermanagement
-- ----------------------------
CREATE TABLE `tbl_usermanagement` (
  `username` varchar(15) DEFAULT NULL,
  `password` varchar(15) DEFAULT NULL,
  `usergroup` varchar(15) DEFAULT NULL,
  `fullname` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records 
-- ----------------------------
INSERT INTO `tbl_employee` VALUES ('07100531', 'Bicera, Kier Allen G.', 'Naguilian, La Union Philippines', '09488164014', 'add_ni_kier@yahoo.com', 'August 10, 1991', '24', 'Naguilian, La Union', 'Male', 'Single', 'September 2, 1991');
INSERT INTO `tbl_payroll` VALUES ('07100532', 'Bicera, Kier Allen G.', '500', '15', '2', '5', '50', '200', '200', '150', '1000', '400', '1950', '7750', '5800', 'Thursday, September 1, 2016', 'Thursday, September 15, 2016', '');
INSERT INTO `tbl_usermanagement` VALUES ('admin', 'admin', 'Admin', 'Bicera, Kier Allen G.');
INSERT INTO `tbl_usermanagement` VALUES ('client', 'client', 'Client', 'Bicera, Kevin LLoyd G.');
