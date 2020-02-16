-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: localhost    Database: mydb
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
-- Table structure for table `tb_ator`
--

DROP TABLE IF EXISTS `tb_ator`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_ator` (
  `idAtor` int(11) NOT NULL,
  `nome_Ator` varchar(80) NOT NULL,
  `sexo_Ator` varchar(20) NOT NULL,
  PRIMARY KEY (`idAtor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_ator`
--

LOCK TABLES `tb_ator` WRITE;
/*!40000 ALTER TABLE `tb_ator` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_ator` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_cinema`
--

DROP TABLE IF EXISTS `tb_cinema`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_cinema` (
  `idCinema` int(11) NOT NULL,
  `Capacidade` int(11) NOT NULL,
  `Localizacao` varchar(80) NOT NULL,
  `idFilmeFK` int(11) NOT NULL,
  PRIMARY KEY (`idCinema`),
  KEY `fk_tb_cinema_tb_filme1_idx` (`idFilmeFK`),
  CONSTRAINT `fk_tb_cinema_tb_filme1` FOREIGN KEY (`idFilmeFK`) REFERENCES `tb_filme` (`idFilme`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_cinema`
--

LOCK TABLES `tb_cinema` WRITE;
/*!40000 ALTER TABLE `tb_cinema` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_cinema` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_filme`
--

DROP TABLE IF EXISTS `tb_filme`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_filme` (
  `idFilme` int(11) NOT NULL,
  `nome_Filme` varchar(80) NOT NULL,
  `Duracao` varchar(35) NOT NULL,
  `Classificacao_Ind` int(11) NOT NULL,
  `_Data` varchar(10) NOT NULL,
  `idAtorFK` int(11) NOT NULL,
  `idDiretorPFK` int(11) NOT NULL,
  `idGeneroPFK` int(11) NOT NULL,
  PRIMARY KEY (`idFilme`,`idDiretorPFK`,`idGeneroPFK`),
  KEY `fk_tb_filme_tb_ator_idx` (`idAtorFK`),
  KEY `fk_tb_filme_tb_ator1_idx` (`idDiretorPFK`),
  KEY `fk_tb_filme_tb_genero1_idx` (`idGeneroPFK`),
  CONSTRAINT `fk_tb_filme_tb_ator` FOREIGN KEY (`idAtorFK`) REFERENCES `tb_ator` (`idAtor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_filme_tb_ator1` FOREIGN KEY (`idDiretorPFK`) REFERENCES `tb_ator` (`idAtor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_filme_tb_genero1` FOREIGN KEY (`idGeneroPFK`) REFERENCES `tb_genero` (`idGenero`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_filme`
--

LOCK TABLES `tb_filme` WRITE;
/*!40000 ALTER TABLE `tb_filme` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_filme` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_filme_estrangeiro`
--

DROP TABLE IF EXISTS `tb_filme_estrangeiro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_filme_estrangeiro` (
  `estudio_Dublagem` varchar(100) NOT NULL,
  `Nacionalidade` varchar(50) NOT NULL,
  `idFilmePFK` int(11) NOT NULL,
  `idDiretorPFK` int(11) NOT NULL,
  `idGeneroPFK` int(11) NOT NULL,
  PRIMARY KEY (`idFilmePFK`,`idDiretorPFK`,`idGeneroPFK`),
  CONSTRAINT `fk_tb_filme_estrangeiro_tb_filme1` FOREIGN KEY (`idFilmePFK`, `idDiretorPFK`, `idGeneroPFK`) REFERENCES `tb_filme` (`idFilme`, `idDiretorPFK`, `idGeneroPFK`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_filme_estrangeiro`
--

LOCK TABLES `tb_filme_estrangeiro` WRITE;
/*!40000 ALTER TABLE `tb_filme_estrangeiro` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_filme_estrangeiro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_filme_nacional`
--

DROP TABLE IF EXISTS `tb_filme_nacional`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_filme_nacional` (
  `idFilmePFK` int(11) NOT NULL,
  `idDiretorPFK` int(11) NOT NULL,
  `idGeneroPFK` int(11) NOT NULL,
  PRIMARY KEY (`idFilmePFK`,`idDiretorPFK`,`idGeneroPFK`),
  CONSTRAINT `fk_tb_filme_nacional_tb_filme1` FOREIGN KEY (`idFilmePFK`, `idDiretorPFK`, `idGeneroPFK`) REFERENCES `tb_filme` (`idFilme`, `idDiretorPFK`, `idGeneroPFK`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_filme_nacional`
--

LOCK TABLES `tb_filme_nacional` WRITE;
/*!40000 ALTER TABLE `tb_filme_nacional` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_filme_nacional` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_genero`
--

DROP TABLE IF EXISTS `tb_genero`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_genero` (
  `idGenero` int(11) NOT NULL,
  `nome_Genero` varchar(60) NOT NULL,
  PRIMARY KEY (`idGenero`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_genero`
--

LOCK TABLES `tb_genero` WRITE;
/*!40000 ALTER TABLE `tb_genero` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_genero` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-03-21 11:18:56
