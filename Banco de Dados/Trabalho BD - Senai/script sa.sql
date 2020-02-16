-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
SHOW WARNINGS;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`tb_ator`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tb_ator` (
  `idAtor` INT(11) NOT NULL,
  `nome_Ator` VARCHAR(80) NOT NULL,
  `sexo_Ator` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`idAtor`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `mydb`.`tb_genero`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tb_genero` (
  `idGenero` INT(11) NOT NULL,
  `nome_Genero` VARCHAR(60) NOT NULL,
  PRIMARY KEY (`idGenero`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `mydb`.`tb_filme`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tb_filme` (
  `idFilme` INT(11) NOT NULL,
  `nome_Filme` VARCHAR(80) NOT NULL,
  `Duracao` VARCHAR(35) NOT NULL,
  `Classificao_Ind` INT(11) NOT NULL,
  `_Data` VARCHAR(10) NOT NULL,
  `idAtorFK` INT(11) NOT NULL,
  `idDiretorPFK` INT(11) NOT NULL,
  `idGeneroPFK` INT(11) NOT NULL,
  PRIMARY KEY (`idFilme`, `idDiretorPFK`, `idGeneroPFK`),
  INDEX `fk_tb_filme_tb_ator_idx` (`idAtorFK` ASC),
  INDEX `fk_tb_filme_tb_ator1_idx` (`idDiretorPFK` ASC),
  INDEX `fk_tb_filme_tb_genero1_idx` (`idGeneroPFK` ASC),
  CONSTRAINT `fk_tb_filme_tb_ator`
    FOREIGN KEY (`idAtorFK`)
    REFERENCES `mydb`.`tb_ator` (`idAtor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_filme_tb_ator1`
    FOREIGN KEY (`idDiretorPFK`)
    REFERENCES `mydb`.`tb_ator` (`idAtor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tb_filme_tb_genero1`
    FOREIGN KEY (`idGeneroPFK`)
    REFERENCES `mydb`.`tb_genero` (`idGenero`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `mydb`.`tb_cinema`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tb_cinema` (
  `idCinema` INT(11) NOT NULL,
  `Capacidade` INT(11) NOT NULL,
  `Localizacao` VARCHAR(80) NOT NULL,
  `idFilmeFK` INT(11) NOT NULL,
  PRIMARY KEY (`idCinema`),
  INDEX `fk_tb_cinema_tb_filme1_idx` (`idFilmeFK` ASC),
  CONSTRAINT `fk_tb_cinema_tb_filme1`
    FOREIGN KEY (`idFilmeFK`)
    REFERENCES `mydb`.`tb_filme` (`idFilme`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `mydb`.`tb_filme_estrangeiro`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tb_filme_estrangeiro` (
  `estudio_Dublagem` VARCHAR(100) NOT NULL,
  `Nacionalidade` VARCHAR(50) NOT NULL,
  `idFilmePFK` INT NOT NULL,
  `idDiretorPFK` INT(11) NOT NULL,
  `idGeneroPFK` INT(11) NOT NULL,
  PRIMARY KEY (`idFilmePFK`, `idDiretorPFK`, `idGeneroPFK`),
  CONSTRAINT `fk_tb_filme_estrangeiro_tb_filme1`
    FOREIGN KEY (`idFilmePFK` , `idDiretorPFK` , `idGeneroPFK`)
    REFERENCES `mydb`.`tb_filme` (`idFilme` , `idDiretorPFK` , `idGeneroPFK`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `mydb`.`tb_filme_nacional`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tb_filme_nacional` (
  `idFilmePFK` INT(11) NOT NULL,
  `idDiretorPFK` INT(11) NOT NULL,
  `idGeneroPFK` INT(11) NOT NULL,
  PRIMARY KEY (`idFilmePFK`, `idDiretorPFK`, `idGeneroPFK`),
  CONSTRAINT `fk_tb_filme_nacional_tb_filme1`
    FOREIGN KEY (`idFilmePFK` , `idDiretorPFK` , `idGeneroPFK`)
    REFERENCES `mydb`.`tb_filme` (`idFilme` , `idDiretorPFK` , `idGeneroPFK`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

SHOW WARNINGS;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
