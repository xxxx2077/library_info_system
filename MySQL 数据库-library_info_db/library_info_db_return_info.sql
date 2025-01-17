-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: library_info_db
-- ------------------------------------------------------
-- Server version	8.0.34

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `return_info`
--

DROP TABLE IF EXISTS `return_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `return_info` (
  `RtNo` int NOT NULL AUTO_INCREMENT,
  `BrNo` int NOT NULL,
  `SNo` char(8) NOT NULL,
  `MID` int NOT NULL DEFAULT '1',
  `RtDTime` datetime NOT NULL,
  `RtOverdue` tinyint(1) NOT NULL DEFAULT '0',
  `RtDamaged` tinyint(1) NOT NULL DEFAULT '0',
  `RtLost` tinyint(1) NOT NULL DEFAULT '0',
  `BtStatus` tinyint(1) NOT NULL DEFAULT '0',
  `OverdueDays` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`RtNo`),
  KEY `FK_Reference_8` (`BrNo`),
  KEY `FK_Reference_9` (`SNo`),
  CONSTRAINT `FK_Reference_8` FOREIGN KEY (`BrNo`) REFERENCES `borrow_info` (`BrNo`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FK_Reference_9` FOREIGN KEY (`SNo`) REFERENCES `reader_info` (`SNo`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `return_info`
--

LOCK TABLES `return_info` WRITE;
/*!40000 ALTER TABLE `return_info` DISABLE KEYS */;
INSERT INTO `return_info` VALUES (18,36,'21311138',2,'2024-01-23 15:38:00',0,0,0,1,0),(19,35,'21311138',2,'2024-01-23 15:39:38',1,0,0,1,335),(20,33,'21311138',2,'2024-01-23 15:41:13',0,1,0,1,0),(21,34,'21311138',2,'2024-01-23 15:42:24',0,0,1,1,0);
/*!40000 ALTER TABLE `return_info` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-25 15:03:35
