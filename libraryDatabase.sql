CREATE DATABASE  IF NOT EXISTS `library` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `library`;
-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: library
-- ------------------------------------------------------
-- Server version	8.0.33

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
-- Table structure for table `irbook`
--

DROP TABLE IF EXISTS `irbook`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `irbook` (
  `id` int NOT NULL AUTO_INCREMENT,
  `memno` varchar(250) NOT NULL,
  `memname` varchar(250) NOT NULL,
  `contact` bigint NOT NULL,
  `email` varchar(250) NOT NULL,
  `bookname` varchar(1250) NOT NULL,
  `issuedate` varchar(250) NOT NULL,
  `returndate` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `irbook`
--

LOCK TABLES `irbook` WRITE;
/*!40000 ALTER TABLE `irbook` DISABLE KEYS */;
INSERT INTO `irbook` VALUES (1,'W1972','Ashok Vijay',713425673,'ashok034@gmail.com','Information Management','Saturday, June 24, 2023','Saturday, June 24, 2023'),(2,'W1972','Ashok Vijay',713425673,'ashok034@gmail.com','Harry Potter','Saturday, June 24, 2023','Saturday, June 24, 2023'),(3,'W1972','Ashok Vijay',713425673,'ashok034@gmail.com','Madol Duwa','Saturday, June 24, 2023','Saturday, June 24, 2023'),(4,'W1972','Ashok Vijay',713425673,'ashok034@gmail.com','Yuganthaya','Saturday, June 24, 2023',NULL),(5,'W1972','Ashok Vijay',713425673,'ashok034@gmail.com','Mary Jane','Saturday, June 24, 2023','Saturday, June 24, 2023'),(6,'W2180','Chathuri ayesha',714253674,'abcathuri@gmail.com','Madol Duwa','Saturday, June 24, 2023',NULL),(7,'W2180','Chathuri ayesha',714253674,'abcathuri@gmail.com','Information Management','Saturday, June 24, 2023',NULL),(8,'W2180','Chathuri ayesha',714253674,'abcathuri@gmail.com','Harry Potter','Saturday, June 24, 2023',NULL),(9,'W6753','Nethmi ahinsa',713497654,'nethmiahinsa@gmail.com','Information Management','Saturday, June 24, 2023',NULL),(10,'W6753','Nethmi ahinsa',713497654,'nethmiahinsa@gmail.com','Harry Potter','Saturday, June 24, 2023',NULL),(11,'W6753','Nethmi ahinsa',713497654,'nethmiahinsa@gmail.com','A tale of two cities','Saturday, June 24, 2023',NULL),(12,'W6753','Nethmi ahinsa',713497654,'nethmiahinsa@gmail.com','Madol Duwa','Saturday, June 24, 2023',NULL),(13,'W1500','Tharusha Jayawardhena',752198764,'tharusha25@gmail.com','Sherlock Homes','Saturday, June 24, 2023','Saturday, June 24, 2023'),(14,'W1972','Ashok Vijay',713425673,'ashok034@gmail.com','Information Management','Saturday, June 24, 2023',NULL),(15,'W1972','Ashok Vijay',713425673,'ashok034@gmail.com','Information Management','Saturday, June 24, 2023',NULL),(16,'W1972','Ashok Vijay',713425673,'ashok034@gmail.com','Madol Duwa','Saturday, June 24, 2023',NULL),(17,'W1972','Ashok Vijay',713425673,'ashok034@gmail.com','Oshin','Saturday, June 24, 2023',NULL),(18,'W1972','Ashok Vijay',713425673,'ashok034@gmail.com','A tale of two cities','Saturday, June 24, 2023',NULL),(19,'W1972','Ashok Vijay',713425673,'ashok034@gmail.com','Buddhist Culcture','Saturday, June 24, 2023',NULL),(20,'W1972','Ashok Vijay',713425673,'ashok034@gmail.com',' Cooking Receipies','Saturday, June 24, 2023',NULL);
/*!40000 ALTER TABLE `irbook` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `logintable`
--

DROP TABLE IF EXISTS `logintable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `logintable` (
  `id` int NOT NULL AUTO_INCREMENT,
  `user` varchar(150) NOT NULL,
  `password` varchar(150) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `logintable`
--

LOCK TABLES `logintable` WRITE;
/*!40000 ALTER TABLE `logintable` DISABLE KEYS */;
INSERT INTO `logintable` VALUES (1,'user2023','abc2023');
/*!40000 ALTER TABLE `logintable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `newbook`
--

DROP TABLE IF EXISTS `newbook`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `newbook` (
  `bid` int NOT NULL AUTO_INCREMENT,
  `bName` varchar(250) NOT NULL,
  `bAuthor` varchar(250) NOT NULL,
  `bPubl` varchar(250) NOT NULL,
  `bPDate` varchar(250) NOT NULL,
  `bPrice` bigint NOT NULL,
  `bQuantity` bigint NOT NULL,
  PRIMARY KEY (`bid`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `newbook`
--

LOCK TABLES `newbook` WRITE;
/*!40000 ALTER TABLE `newbook` DISABLE KEYS */;
INSERT INTO `newbook` VALUES (2,'Information Management','Mr.H.D.Ashok Kumar ','Thick Publications','Monday, May 18, 2020',3000,25),(3,'Harry POTER','J.K.Rolling','Cinamatix Creation','Monday, November 1, 2010',1500,50),(4,'A tale of two cities','C.Dickens','XY publications','Tuesday, July 18, 2000',850,30),(5,'Madol Duwa','Martin Wickramasinghe','Sinhawansha Publication','Friday, June 30, 2000',500,70),(6,'Yuganthaya','Martin Wickramasinghe','Sinhawansha Publication','Friday, January 1, 1993',675,45),(7,'Mary Jane','Arnold Paul ','City Publication','Sunday, November 14, 2010',1020,50),(8,'Sherlock Homes','Chandana Bandara','Apa Publications','Tuesday, October 18, 2011',850,12),(9,'Oshin','Himamoto Akamthsu','Origatho Publications','Friday, August 20, 2004',1500,35),(10,'Buddhist Culcture','Mahanama Thero','Apa publications','Tuesday, January 20, 2004',2500,45),(11,' Cooking Receipies','Onali Tharushi','XY Publication','Sunday, June 6, 2021',1200,23),(12,' English Grammer','Ronald Aurthur','FDS Publication','Thursday, July 11, 2013',500,32);
/*!40000 ALTER TABLE `newbook` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `newstudent`
--

DROP TABLE IF EXISTS `newstudent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `newstudent` (
  `stuid` int NOT NULL AUTO_INCREMENT,
  `sname` varchar(250) NOT NULL,
  `memno` varchar(250) NOT NULL,
  `contact` bigint NOT NULL,
  `email` varchar(250) NOT NULL,
  PRIMARY KEY (`stuid`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `newstudent`
--

LOCK TABLES `newstudent` WRITE;
/*!40000 ALTER TABLE `newstudent` DISABLE KEYS */;
INSERT INTO `newstudent` VALUES (3,'Ashok Vijay','W1972',713425673,'ashok034@gmail.com'),(4,'Chathuri ayesha','W2180',714253674,'abcathuri@gmail.com'),(5,'Yoshini Bethmi','W3124',712345987,'yoshib@gmail.com'),(6,'Nethmi ahinsa','W6753',713497654,'nethmiahinsa@gmail.com'),(7,'Nethmal abhi','W4398',719976542,'abhinethmal@gmail.com'),(8,'Fathima Zammir','W5641',717642536,'fathimaz2gmail.com'),(9,'Nethmi Perera','W1000',712348765,'nethmiperera@gmail.com'),(10,'Tharusha Jayawardhena','W1500',752198764,'tharusha25@gmail.com');
/*!40000 ALTER TABLE `newstudent` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-25 14:04:17
