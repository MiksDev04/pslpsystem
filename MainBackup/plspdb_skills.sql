-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: plspdb
-- ------------------------------------------------------
-- Server version	8.0.40

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
-- Table structure for table `skills`
--

DROP TABLE IF EXISTS `skills`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `skills` (
  `skill_id` int NOT NULL AUTO_INCREMENT,
  `Skill_Name` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`skill_id`)
) ENGINE=InnoDB AUTO_INCREMENT=573 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `skills`
--

LOCK TABLES `skills` WRITE;
/*!40000 ALTER TABLE `skills` DISABLE KEYS */;
INSERT INTO `skills` VALUES (394,'Cooking, Eating, Sleeping'),(398,'Calisthenics, Programming, Sleeping'),(399,'N/A'),(400,'Killing aswang, Swimming'),(401,'sdsad'),(402,'Fortified flexibility, Conversational exchanges, Growing independent skill set, energized collaboritory'),(403,'N/A'),(404,'Singing, Dancing'),(406,'Painting, Drawing, Cooking'),(407,'Dancing'),(408,'Communication Skillg'),(409,'Time management, Critical Thinking, Adaptability, Communication'),(410,'Critical thinking'),(411,'Time management, Critical Thinking, Adaptability, Communication'),(412,'Critical thinking'),(413,'Time management, Critical Thinking, Adaptability, Communication'),(414,'Critical thinking'),(415,'Computer Literature'),(416,'Music Producer, Beat maker'),(417,'N/A'),(418,'Dancing, Singing '),(419,'N/A'),(420,'N/A'),(421,'N/A'),(423,'Cooking, Crafts, Photography, Singing '),(424,'Cleanliness'),(425,'Problem solving'),(426,'Critical thinking'),(427,'Public speaking'),(428,'Writing'),(429,'Running, Swimming'),(430,'Cooking, Dancing, Flexible'),(431,'Cooking, Cleaning, Singing, Dancing, Watching'),(432,'Dancing, Basketball, Cooking'),(433,'Musical Instrument'),(434,'Cooking, Dancing, Musical Instrument'),(435,'Time management, Oral and written communication, Critical thinking, Teamwork'),(436,'Multi-tasking, Self-awareness'),(437,'Observation skills, Communication skills, Stress management, Self discipline,Adaptabiliy'),(438,'Dedicated learner, listener, Communicaton Skill'),(439,'Communication skill, Teamwork'),(440,'Problem solving, Adaptability, Critical thinking, Active listening'),(441,'Time management, Critical Thinking, Research Skill, Discipline, Responsible'),(442,'Social skills, Decision making, Calligraphy, Drawings, Adaptability, Time management, Gaming'),(443,'Time management, Critical Thinking, Cultural competence, Time management, Open minded, Behavior observation, Group Dynamic, Socializing'),(444,'Drawing, Playing Instrument, Basketball, Gaming, Chess'),(445,'Data Analysis, Emotional intelligence, Design, Adaptability, Flexibility'),(446,'Communication Skill, Singing, Cooking, Adaptability, Teamwork and Collaboration'),(447,'Communication Skills'),(448,'N/A'),(449,'Drawing, Playing Instrument, Basketball, Gaming, Chess'),(450,'Data Analysis, Emotional intelligence, Design, Adaptability, Flexibility'),(451,'Communication Skill, Singing, Cooking, Adaptability, Teamwork and Collaboration'),(452,'Time management, Communication skill'),(453,'Communication Skill'),(454,'N/A'),(455,'N/A'),(456,'N/A'),(457,'N/A'),(458,'Communication Skill'),(459,'N/A'),(460,'N/A'),(461,'N/A'),(462,'Communication Skill'),(463,'Communication Skill'),(464,'Interpersonal Skill'),(465,'Multi-tasking, Goal oriented, Ability to  work under pressure'),(466,'Critical thinking'),(467,'Communication skill, Interpersonal skill'),(468,'Problem solving, Adaptability, Critical thinking, Active listening'),(469,'Time management, Critical Thinking, Research Skill, Discipline, Responsible'),(470,'Communication Skill, Singing, Cooking, Adaptability, Teamwork and Collaboration'),(471,'Analyzing, Critical Thinking'),(472,'Active Listener, Dancing, Reading, Watching Movies, Multimedia Skills, Critical Thinking, Singing, Filming, Photography, Active Learner'),(473,'Singing, Reading Comprehension, Dancing, Public Speaking, Critical Thinking, Problem Sloving'),(474,'Fast Learner, Overthinker, Composer, Guitar skill'),(475,'Time Management, Computer Literacy'),(476,'Creativity, Computer Literacy, Leadership, Analytical Skills, Document Processing'),(477,'Leadership, Emotional Intelligence, Communication Skills, Critical Thinking'),(478,'Creative, Cooperative'),(479,'N/A'),(480,'Time Management, Communication Skills'),(481,'Painting, Drawing, Cooking'),(482,'N/A'),(483,'N/A'),(484,'N/A'),(485,'N/A'),(486,'N/A'),(487,'N/A'),(488,'N/A'),(489,'N/A'),(490,'N/A'),(491,'N/A'),(492,'N/A'),(493,'N/A'),(494,'N/A'),(495,'N/A'),(496,'N/A'),(497,'N/A'),(498,'N/A'),(499,'N/A'),(500,'N/A'),(501,'N/A'),(502,'N/A'),(503,'N/A'),(504,'N/A'),(508,'Online Game, Basketball, Drawing, Coding'),(509,'Cooking, Driving, Drawing'),(510,'Cooking, Drawing, Multitasking, Computer Literate'),(511,'Cooking, Driving, Drawing'),(512,'Programming, Drawing, Cooking'),(513,'Dancing'),(514,'Leadership, Analytical Skills'),(515,'Leadership, Communication Skills'),(516,'Orgazational Skills, Leadership, Communication'),(517,'Programming, Drawing, Cooking'),(518,'Leadership, Communication Skills'),(545,'Communication'),(546,'Badminton, Dancing'),(547,'Good Communication, Public Speaking'),(548,'Singing, Dancing'),(549,'Singing, Dancing'),(550,'Acting'),(551,'Teamwork, Volleyball, Problem Solving'),(552,'Basketball'),(553,'Singing'),(554,'Flexible, Futsal'),(555,'N/A'),(556,'N/A'),(557,'N/A'),(558,'N/A'),(559,'N/A'),(560,'N/A'),(561,'N/A'),(562,'N/A'),(563,'N/A'),(564,'N/A'),(565,'N/A'),(566,'N/A'),(567,'N/A'),(568,'N/A'),(569,'N/A'),(570,'N/A'),(571,'N/A'),(572,'N/A');
/*!40000 ALTER TABLE `skills` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-02-01  5:02:50
