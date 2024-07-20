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
-- Table structure for table `book_typeinfo`
--

DROP TABLE IF EXISTS `book_typeinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `book_typeinfo` (
  `BTNo` int NOT NULL AUTO_INCREMENT,
  `BTName` varchar(60) NOT NULL,
  PRIMARY KEY (`BTNo`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `book_typeinfo`
--

LOCK TABLES `book_typeinfo` WRITE;
/*!40000 ALTER TABLE `book_typeinfo` DISABLE KEYS */;
INSERT INTO `book_typeinfo` VALUES (1,'A 马克思主义、列宁主义、毛泽东思想、邓小平理论'),(2,'B 哲学、宗教'),(3,'C 社会科学总论'),(4,'D 政治、法律'),(5,'E 军事'),(6,'F 经济'),(7,'G 文化、科学、教育、体育'),(8,'H 语言、文字'),(9,'I 文学'),(10,'J 艺术'),(11,'K 历史、地理'),(12,'N 自然科学总论'),(13,'O 数理科学和化学'),(14,'P 天文学、地球科学'),(15,'Q 生物科学'),(16,'R 医药、卫生'),(17,'S 农业科学'),(18,'T 工业技术'),(19,'U 交通运输'),(20,'V 航空、航天'),(21,'X 环境科学、安全科学'),(22,'Z 综合性图书');
/*!40000 ALTER TABLE `book_typeinfo` ENABLE KEYS */;
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
