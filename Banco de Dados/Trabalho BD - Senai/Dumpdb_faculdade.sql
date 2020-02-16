-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: localhost    Database: db_faculdade
-- ------------------------------------------------------
-- Server version	5.5.5-10.1.10-MariaDB

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
-- Table structure for table `tb_aluno`
--

DROP TABLE IF EXISTS `tb_aluno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_aluno` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `nome` varchar(120) DEFAULT NULL,
  `dt_nascimento` date DEFAULT NULL,
  `dt_matricula` date DEFAULT NULL,
  `ra` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  UNIQUE KEY `ra_UNIQUE` (`ra`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_aluno`
--

LOCK TABLES `tb_aluno` WRITE;
/*!40000 ALTER TABLE `tb_aluno` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_aluno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_disciplina`
--

DROP TABLE IF EXISTS `tb_disciplina`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_disciplina` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(120) DEFAULT NULL,
  `carga_horaria` int(11) DEFAULT NULL,
  `id_professor` int(10) unsigned NOT NULL,
  UNIQUE KEY `id_UNIQUE` (`id`),
  KEY `fk_disciplina_professor_idx` (`id_professor`),
  CONSTRAINT `fk_disciplina_professor` FOREIGN KEY (`id_professor`) REFERENCES `tb_professor` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_disciplina`
--

LOCK TABLES `tb_disciplina` WRITE;
/*!40000 ALTER TABLE `tb_disciplina` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_disciplina` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_professor`
--

DROP TABLE IF EXISTS `tb_professor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_professor` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nome` varchar(120) DEFAULT NULL,
  `dt_nascimento` date DEFAULT NULL,
  `registro` int(11) NOT NULL,
  `grau_form` varchar(120) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `registro_UNIQUE` (`registro`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_professor`
--

LOCK TABLES `tb_professor` WRITE;
/*!40000 ALTER TABLE `tb_professor` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_professor` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-05-17 10:27:41
