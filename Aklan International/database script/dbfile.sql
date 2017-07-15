CREATE DATABASE  IF NOT EXISTS `dbcore` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `dbcore`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: dbcore
-- ------------------------------------------------------
-- Server version	5.7.17-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `dtcustomer_orders`
--

DROP TABLE IF EXISTS `dtcustomer_orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dtcustomer_orders` (
  `OrderId` int(11) NOT NULL,
  `OrderDateTime` datetime DEFAULT NULL,
  `CustomerId` varchar(10) DEFAULT NULL,
  `CustomerName` varchar(45) DEFAULT NULL,
  `CustomerContact` varchar(15) DEFAULT NULL,
  `description` varchar(100) DEFAULT NULL,
  `SingleSheetQty` int(11) DEFAULT NULL,
  `SingleSheetUnit` decimal(10,2) DEFAULT NULL,
  `DozenSheetQty` int(11) DEFAULT NULL,
  `DozenSheetUnit` decimal(10,2) DEFAULT NULL,
  `TotalPrice` decimal(10,2) DEFAULT NULL,
  `AmountPaid` decimal(10,2) DEFAULT NULL,
  `AmountRemaining` decimal(10,2) DEFAULT NULL,
  `finished` varchar(3) DEFAULT NULL,
  PRIMARY KEY (`OrderId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dtcustomer_orders`
--

LOCK TABLES `dtcustomer_orders` WRITE;
/*!40000 ALTER TABLE `dtcustomer_orders` DISABLE KEYS */;
/*!40000 ALTER TABLE `dtcustomer_orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dtjobrates`
--

DROP TABLE IF EXISTS `dtjobrates`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dtjobrates` (
  `job` varchar(20) NOT NULL,
  `rate` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`job`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dtjobrates`
--

LOCK TABLES `dtjobrates` WRITE;
/*!40000 ALTER TABLE `dtjobrates` DISABLE KEYS */;
INSERT INTO `dtjobrates` VALUES ('clip cutting',5),('cutting',5),('folding 12',5),('folding single',5),('rimming',5);
/*!40000 ALTER TABLE `dtjobrates` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dtlogin`
--

DROP TABLE IF EXISTS `dtlogin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dtlogin` (
  `empID` varchar(255) NOT NULL,
  `psw` varchar(20) DEFAULT NULL,
  `empName` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`empID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dtlogin`
--

LOCK TABLES `dtlogin` WRITE;
/*!40000 ALTER TABLE `dtlogin` DISABLE KEYS */;
INSERT INTO `dtlogin` VALUES ('a001','1234','shehan'),('s001','1234','kamal'),('sm001','1234','saman'),('w001','1234','nimal');
/*!40000 ALTER TABLE `dtlogin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dtmaterial`
--

DROP TABLE IF EXISTS `dtmaterial`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dtmaterial` (
  `index` int(11) NOT NULL,
  `empID` varchar(20) DEFAULT NULL,
  `date` varchar(12) DEFAULT NULL,
  `description` varchar(100) DEFAULT NULL,
  `material` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`index`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dtmaterial`
--

LOCK TABLES `dtmaterial` WRITE;
/*!40000 ALTER TABLE `dtmaterial` DISABLE KEYS */;
INSERT INTO `dtmaterial` VALUES (1,'a001','7/6/2017','admin updated stock','50,0,0,0,0');
/*!40000 ALTER TABLE `dtmaterial` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dtsalary`
--

DROP TABLE IF EXISTS `dtsalary`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dtsalary` (
  `index` varchar(30) NOT NULL,
  `salary` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`index`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dtsalary`
--

LOCK TABLES `dtsalary` WRITE;
/*!40000 ALTER TABLE `dtsalary` DISABLE KEYS */;
/*!40000 ALTER TABLE `dtsalary` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dtsales`
--

DROP TABLE IF EXISTS `dtsales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dtsales` (
  `Customer` varchar(45) NOT NULL,
  `NIC` varchar(45) NOT NULL,
  `Tel` varchar(45) DEFAULT NULL,
  `Type` varchar(45) DEFAULT NULL,
  `Qty` varchar(45) DEFAULT NULL,
  `Unit_Price` varchar(45) DEFAULT NULL,
  `Amount` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`NIC`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dtsales`
--

LOCK TABLES `dtsales` WRITE;
/*!40000 ALTER TABLE `dtsales` DISABLE KEYS */;
INSERT INTO `dtsales` VALUES ('Mahesh','942291515V','712488893','Single','5','120','600'),('Chathuranga','953278945V','0713604485','12 sheets','8','150','1200');
/*!40000 ALTER TABLE `dtsales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dtunitprices`
--

DROP TABLE IF EXISTS `dtunitprices`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dtunitprices` (
  `TypeId` int(11) NOT NULL,
  `TypeName` varchar(45) NOT NULL,
  `UnitPrice` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`TypeId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dtunitprices`
--

LOCK TABLES `dtunitprices` WRITE;
/*!40000 ALTER TABLE `dtunitprices` DISABLE KEYS */;
INSERT INTO `dtunitprices` VALUES (1,'Single Sheet',100.57),(2,'Dozen Sheets',23.58);
/*!40000 ALTER TABLE `dtunitprices` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dtw001`
--

DROP TABLE IF EXISTS `dtw001`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dtw001` (
  `index` int(11) NOT NULL,
  `date` varchar(20) DEFAULT NULL,
  `matType` varchar(45) DEFAULT NULL,
  `job` varchar(45) DEFAULT NULL,
  `Qty` int(11) DEFAULT NULL,
  `finished` varchar(3) DEFAULT NULL,
  PRIMARY KEY (`index`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dtw001`
--

LOCK TABLES `dtw001` WRITE;
/*!40000 ALTER TABLE `dtw001` DISABLE KEYS */;
INSERT INTO `dtw001` VALUES (1,'7/12/2017','sheet','cutting',3,'yes'),(2,'7/12/2017','sheet','cutting',0,'yes'),(3,'7/12/2017','sheet','cutting',2,'yes');
/*!40000 ALTER TABLE `dtw001` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `worker_details`
--

DROP TABLE IF EXISTS `worker_details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `worker_details` (
  `empID` varchar(10) NOT NULL,
  `first_name` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `tel_NO` int(11) DEFAULT NULL,
  `last_name` varchar(45) DEFAULT NULL,
  `worker_type` varchar(45) DEFAULT NULL,
  `nic_NO` varchar(45) DEFAULT NULL,
  `gender` varchar(20) DEFAULT NULL,
  `dob` varchar(25) DEFAULT NULL,
  `acc_NO` varchar(45) DEFAULT NULL,
  `deleted` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`empID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `worker_details`
--

LOCK TABLES `worker_details` WRITE;
/*!40000 ALTER TABLE `worker_details` DISABLE KEYS */;
INSERT INTO `worker_details` VALUES ('',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),('a001','shehan','1234','potuhera',711111111,'rajakaruna','admin','4589','male','5/8/1995','5454564654','no');
/*!40000 ALTER TABLE `worker_details` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-07-15 12:05:00
