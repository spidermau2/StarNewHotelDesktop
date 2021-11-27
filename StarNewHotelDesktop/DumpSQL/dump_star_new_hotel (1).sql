-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: star_new_hotel
-- ------------------------------------------------------
-- Server version	8.0.27

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
-- Temporary view structure for view `resumo`
--

DROP TABLE IF EXISTS `resumo`;
/*!50001 DROP VIEW IF EXISTS `resumo`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `resumo` AS SELECT 
 1 AS `Reserva`,
 1 AS `Entrada`,
 1 AS `Saida`,
 1 AS `Cliente`,
 1 AS `Pagamento`,
 1 AS `Quarto`,
 1 AS `Refeicao`,
 1 AS `ValorRefeicao`,
 1 AS `ValorQuarto`,
 1 AS `Pago`,
 1 AS `Quantidade`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `tb_cliente`
--

DROP TABLE IF EXISTS `tb_cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_cliente` (
  `ID_Cliente` int NOT NULL AUTO_INCREMENT,
  `NM_Cliente` varchar(50) DEFAULT NULL,
  `NR_RG` int DEFAULT NULL,
  `NR_CPF` bigint DEFAULT NULL,
  PRIMARY KEY (`ID_Cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_formapagamento`
--

DROP TABLE IF EXISTS `tb_formapagamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_formapagamento` (
  `ID_Pagamento` int NOT NULL AUTO_INCREMENT,
  `DS_Pagamento` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID_Pagamento`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_quarto`
--

DROP TABLE IF EXISTS `tb_quarto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_quarto` (
  `ID_Quarto` int NOT NULL AUTO_INCREMENT,
  `DS_Quarto` varchar(50) DEFAULT NULL,
  `Valor` decimal(19,4) DEFAULT '0.0000',
  PRIMARY KEY (`ID_Quarto`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_refeicao`
--

DROP TABLE IF EXISTS `tb_refeicao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_refeicao` (
  `ID_Refeicao` int NOT NULL AUTO_INCREMENT,
  `DS_Refeicao` varchar(50) DEFAULT NULL,
  `VL_Refeicao` decimal(19,4) DEFAULT NULL,
  PRIMARY KEY (`ID_Refeicao`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_reserva`
--

DROP TABLE IF EXISTS `tb_reserva`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_reserva` (
  `ID_Reserva` int NOT NULL AUTO_INCREMENT,
  `QT_Reservas` int DEFAULT NULL,
  `HR_Entrada` time DEFAULT NULL,
  `HR_Saida` time DEFAULT NULL,
  `ID_Cliente` int DEFAULT NULL,
  `ID_Pagamento` int DEFAULT NULL,
  `ID_Quarto` int DEFAULT NULL,
  `ID_Refeicao` int DEFAULT NULL,
  `Pago` varchar(1) DEFAULT 'N',
  PRIMARY KEY (`ID_Reserva`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Final view structure for view `resumo`
--

/*!50001 DROP VIEW IF EXISTS `resumo`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `resumo` AS select `re`.`ID_Reserva` AS `Reserva`,`re`.`HR_Entrada` AS `Entrada`,`re`.`HR_Saida` AS `Saida`,`cli`.`NM_Cliente` AS `Cliente`,`pag`.`DS_Pagamento` AS `Pagamento`,`quar`.`DS_Quarto` AS `Quarto`,`ref`.`DS_Refeicao` AS `Refeicao`,`ref`.`VL_Refeicao` AS `ValorRefeicao`,`quar`.`Valor` AS `ValorQuarto`,`re`.`Pago` AS `Pago`,`re`.`QT_Reservas` AS `Quantidade` from ((((`tb_reserva` `re` join `tb_cliente` `cli` on((`re`.`ID_Cliente` = `cli`.`ID_Cliente`))) join `tb_formapagamento` `pag` on((`re`.`ID_Pagamento` = `pag`.`ID_Pagamento`))) join `tb_quarto` `quar` on((`re`.`ID_Quarto` = `quar`.`ID_Quarto`))) join `tb_refeicao` `ref` on((`re`.`ID_Refeicao` = `ref`.`ID_Refeicao`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-11-23 11:53:15
