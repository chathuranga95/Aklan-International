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
-- Table structure for table `dta001`
--

DROP TABLE IF EXISTS `dta001`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dta001` (
  `index` int(11) NOT NULL,
  `date` varchar(20) DEFAULT NULL,
  `matType` varchar(45) DEFAULT NULL,
  `Qty` int(11) DEFAULT NULL,
  `finished` varchar(3) DEFAULT NULL,
  PRIMARY KEY (`index`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dta001`
--

LOCK TABLES `dta001` WRITE;
/*!40000 ALTER TABLE `dta001` DISABLE KEYS */;
INSERT INTO `dta001` VALUES (1,'7/4/2017','Sheet',2,'no');
/*!40000 ALTER TABLE `dta001` ENABLE KEYS */;
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
  `date` date DEFAULT NULL,
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
/*!40000 ALTER TABLE `dtmaterial` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-07-04 23:21:44
