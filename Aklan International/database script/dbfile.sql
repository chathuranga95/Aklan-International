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
  `OrderDateTime` varchar(30) DEFAULT NULL,
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
INSERT INTO `dtcustomer_orders` VALUES (1,'2017-07-17 9:58:30 PM','916566705v','kavindu','(071) 659-8433',' The lovers calender set. blue color.',500,5.00,0,0.00,2500.00,1500.00,1000.00,'no');
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
  `rate` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`job`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dtjobrates`
--

LOCK TABLES `dtjobrates` WRITE;
/*!40000 ALTER TABLE `dtjobrates` DISABLE KEYS */;
INSERT INTO `dtjobrates` VALUES ('Clip Cutting',1.25),('Cutting',50.00),('Folding 12',5.00),('Folding Single',3.50),('Rimming 12',2.50),('Rimming Single',1.50);
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
INSERT INTO `dtlogin` VALUES ('a001','1234','Shehan Rajakaruna'),('s001','1234','Kamal Buwaneka'),('sm001','1234','namal rathnayake'),('w001','1234','Jagath gunatilake'),('w002','1234','Danuka Malinda'),('w003','1234','Dinidu Jeewandara');
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
INSERT INTO `dtmaterial` VALUES (1,'a9999','2017-07-17','initialization','0,0,0,0,0'),(2,'a001','2017-07-17','100 of sheet inserted by Admin','100,0,0,0,0'),(3,'w001','2017-07-17','3 of sheet taken','97,0,0,0,0'),(4,'s001','2017-07-17','150 of cut strip made','97,150,0,0,0'),(5,'w001','2017-07-17','100 of cut strip taken','97,50,0,0,0'),(6,'s001','2017-07-17','95 of clip cut made','97,50,95,0,0'),(7,'w001','2017-07-17','50 of clip cut taken','97,50,45,0,0'),(8,'w001','2017-07-17','40 of clip cut taken','97,50,5,0,0'),(9,'s001','2017-07-17','50 of folded 12 made','97,50,5,50,0'),(10,'s001','2017-07-17','40 of folded single made','97,50,5,50,40'),(11,'s001','2017-07-17','50 of folded 12 made','97,50,5,100,40'),(12,'s001','2017-07-17','40 of folded single made','97,50,5,100,80'),(13,'sm001','2017-07-17','25 of folded single taken','97,50,5,100,55'),(14,'sm001','2017-07-17','30 of folded 12 taken','97,50,5,70,55'),(15,'sm001','2017-07-17','5 of folded single taken','97,50,5,70,50'),(16,'sm001','2017-07-17','6 of folded 12 taken','97,50,5,64,50'),(17,'a001','2017-07-17','100 of sheet inserted by Admin','197,50,5,64,50'),(18,'s001','2017-07-17','20 of folded single taken','197,50,5,64,30'),(19,'s001','2017-07-17','20 of folded 12 taken','197,50,5,44,30'),(20,'w002','2017-07-18','20 of cut strip taken','197,30,5,44,30'),(21,'s001','2017-07-18','20 of clip cut made','197,30,25,44,30');
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
INSERT INTO `dtsalary` VALUES ('7/2017/w001',1205),('7/2017/w002',25);
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
  `Amount` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dtsales`
--

LOCK TABLES `dtsales` WRITE;
/*!40000 ALTER TABLE `dtsales` DISABLE KEYS */;
INSERT INTO `dtsales` VALUES ('Vimukthi','956248301v','0751111111','Single','   25','5.00','125.00'),('','','','12 sheets','30','6.50','195.00'),('athapaththu','956248322v','0764444444','Single','5','5.00','25.00'),('athapaththu','956248322v','0764444444','12 sheets','6','6.50','39.00');
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
INSERT INTO `dtunitprices` VALUES (1,'Single Sheet',5.00),(2,'Dozen Sheets',6.50);
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
INSERT INTO `dtw001` VALUES (1,'2017-07-17','sheet','Cutting',3,'yes'),(2,'2017-07-17','cut strip','Clip Cutting',100,'yes'),(3,'2017-07-17','clip cut','Folding 12',50,'yes'),(4,'2017-07-17','clip cut','Folding Single',40,'no');
/*!40000 ALTER TABLE `dtw001` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dtw002`
--

DROP TABLE IF EXISTS `dtw002`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dtw002` (
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
-- Dumping data for table `dtw002`
--

LOCK TABLES `dtw002` WRITE;
/*!40000 ALTER TABLE `dtw002` DISABLE KEYS */;
INSERT INTO `dtw002` VALUES (1,'2017-07-18','cut strip','Clip Cutting',20,'no');
/*!40000 ALTER TABLE `dtw002` ENABLE KEYS */;
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
  `tel_NO` varchar(20) DEFAULT NULL,
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
INSERT INTO `worker_details` VALUES ('a001','Shehan','1234','Potuhera, Kurunegala','(071) 123-6545','Rajakaruna','admin','926523709v','','1992-May-8','123456','No'),('s001','Kamal','1234','Wadakada, Narammala','(071) 326-5408','Buwaneka','Supervisor','903233405v','Male','1990-Mar-2','123456','No'),('s002','fsdfsdf','1234','ghfhgfhgfhgfh','(071) 555-5555','sdfsdf','Supervisor','123456789v','Male','1980-Jan-1','654789','Yes'),('sm001','namal','1234','udapola, wadakada','(077) 564-8922','rathnayake','Salesman','853465205v','Male','1985-Nov-14','654789','No'),('w001','Jagath','1234','polgahawela','(071) 666-6666','gunatilake','Worker','716534591v','Male','1971-May-6','456987','No'),('w002','Danuka','1234','yanthampalawa, kurunegala','(071) 433-2645','Malinda','Worker','952343107v','Male','1995-Nov-13','123456','No'),('w003','Dinidu','1234','udapola, polgahawela','(071) 271-3333','Jeewandara','Worker','946523403v','Male','1994-Jul-18','646546','No');
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

-- Dump completed on 2017-07-18 11:44:25
