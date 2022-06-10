-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 01 juin 2022 à 17:34
-- Version du serveur : 5.7.36
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `atelier2pro`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `IDPERSONNEL` int(2) NOT NULL,
  `DATEDEBUT` datetime NOT NULL,
  `IDMOTIF` int(2) NOT NULL,
  `DATEFIN` datetime DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`,`DATEDEBUT`),
  KEY `FK_ABSENCE_MOTIF` (`IDMOTIF`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`IDPERSONNEL`, `DATEDEBUT`, `IDMOTIF`, `DATEFIN`) VALUES
(1, '2018-11-23 02:05:11', 2, '2019-08-30 16:10:40'),
(1, '2020-01-11 06:44:35', 2, '2020-12-16 22:42:10'),
(1, '2020-08-08 02:01:06', 2, '2020-08-20 03:55:05'),
(1, '2021-12-25 14:12:37', 2, '2019-04-08 13:18:33'),
(2, '2018-12-10 21:24:51', 1, '2018-09-03 15:56:25'),
(2, '2019-11-25 23:53:14', 3, '2020-08-16 16:38:53'),
(2, '2021-02-16 02:30:09', 2, '2021-05-21 03:40:02'),
(2, '2022-02-19 21:01:26', 2, '2021-10-28 03:39:58'),
(2, '2022-04-18 17:51:57', 3, '2021-03-19 18:17:41'),
(3, '2019-02-11 16:15:11', 1, '2021-05-18 21:19:12'),
(3, '2019-03-12 21:16:37', 1, '2021-02-18 12:05:16'),
(3, '2020-12-17 08:08:02', 2, '2019-11-09 21:38:27'),
(3, '2021-03-19 12:31:45', 1, '2019-12-09 23:51:54'),
(4, '2019-12-27 14:33:55', 3, '2019-09-09 00:51:56'),
(4, '2020-05-15 17:28:03', 2, '2021-02-20 18:27:29'),
(4, '2021-06-30 15:44:25', 3, '2019-09-28 02:18:25'),
(5, '2019-02-19 21:25:52', 3, '2019-01-11 07:38:54'),
(5, '2019-05-02 13:32:50', 2, '2018-10-02 00:31:19'),
(5, '2019-11-19 01:22:53', 1, '2019-08-01 08:01:09'),
(5, '2020-08-01 10:44:08', 3, '2021-02-27 02:42:25'),
(5, '2021-09-19 08:39:07', 3, '2020-06-11 13:51:03'),
(5, '2022-01-29 18:52:13', 2, '2022-03-13 22:36:19'),
(6, '2019-01-19 10:29:57', 3, '2019-04-03 08:01:38'),
(6, '2019-03-09 09:36:52', 1, '2018-09-11 16:06:23'),
(6, '2020-04-16 09:04:16', 2, '2018-10-23 04:14:32'),
(6, '2020-08-22 10:43:54', 2, '2021-03-01 20:47:02'),
(6, '2020-12-28 08:31:03', 2, '2018-09-27 13:41:27'),
(6, '2021-05-01 01:41:46', 2, '2022-02-17 05:45:55'),
(7, '2018-09-27 09:09:23', 2, '2019-04-01 11:22:36'),
(7, '2019-12-21 20:33:23', 3, '2020-11-29 16:12:01'),
(7, '2020-08-31 08:00:50', 1, '2019-03-02 13:24:37'),
(7, '2022-04-17 06:06:44', 3, '2020-03-11 08:10:08'),
(8, '2019-08-28 19:27:48', 1, '2020-04-30 02:54:45'),
(8, '2019-09-01 02:25:34', 2, '2019-09-09 05:26:37'),
(8, '2021-07-24 09:17:10', 2, '2019-01-14 18:10:52'),
(8, '2022-05-18 08:30:07', 2, '2019-02-09 09:34:21'),
(9, '2018-12-13 04:58:29', 2, '2018-12-15 09:14:25'),
(9, '2018-12-17 02:04:07', 3, '2019-07-22 12:39:27'),
(9, '2019-02-14 14:41:31', 2, '2018-10-26 03:08:51'),
(9, '2019-04-15 18:45:35', 3, '2021-08-09 06:26:27'),
(9, '2019-05-24 13:41:47', 1, '2019-03-05 19:14:01'),
(9, '2020-03-01 12:10:59', 2, '2019-02-12 13:46:51'),
(9, '2020-08-27 14:19:41', 1, '2018-09-08 22:44:49'),
(9, '2020-09-05 14:42:03', 3, '2021-04-18 19:23:47'),
(9, '2020-10-26 23:11:09', 1, '2019-02-07 11:30:08'),
(9, '2021-03-27 07:00:11', 2, '2021-08-22 20:03:05'),
(9, '2021-07-18 03:02:07', 3, '2020-05-27 06:54:03'),
(10, '2020-01-19 22:13:32', 3, '2020-05-16 18:52:49'),
(10, '2021-08-05 13:53:29', 2, '2019-04-30 14:08:22'),
(10, '2022-01-24 03:36:09', 3, '2020-10-31 18:39:47');

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `IDMOTIF` int(2) NOT NULL AUTO_INCREMENT,
  `MOTIF` varchar(64) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`IDMOTIF`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`IDMOTIF`, `MOTIF`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `IDPERSONNEL` int(2) NOT NULL AUTO_INCREMENT,
  `IDSERVICE` int(2) NOT NULL,
  `NOM` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `PRENOM` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `TEL` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `MAIL` varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`),
  KEY `FK_PERSONNEL_SERVICE` (`IDSERVICE`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`IDPERSONNEL`, `IDSERVICE`, `NOM`, `PRENOM`, `TEL`, `MAIL`) VALUES
(1, 2, 'Plamondon', 'Violet', '09 54 27 81 67', 'interdum.ligula@protonmail.ca'),
(2, 3, 'Holt', 'Oren', '07 34 74 48 62', 'quis@google.edu'),
(3, 2, 'Tremblay', 'Ria', '02 18 73 70 34', 'feugiat.placerat@google.net'),
(4, 2, 'Royer', 'Stuart', '06 67 86 55 54', 'sapien.aenean.massa@protonmail.net'),
(5, 3, 'Monet', 'Dorian', '08 38 13 68 78', 'lectus.quis@protonmail.net'),
(6, 2, 'Chaput', 'Dylan', '03 29 18 64 12', 'egestas.nunc@protonmail.com'),
(7, 2, 'Cousineau', 'Kirestin', '06 11 31 91 88', 'cum.sociis@icloud.couk'),
(8, 1, 'Dubois', 'Isadora', '04 05 59 88 45', 'enim.nunc@google.ca'),
(9, 1, 'Tailler', 'Paul', '06 64 40 78 25', 'egestas@google.net'),
(10, 1, 'Cloutier', 'Adena', '04 63 74 12 16', 'vivamus.non@google.com');

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8_unicode_ci DEFAULT NULL,
  `pwd` varchar(64) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('administrateur', '9ae3358fee2897f53d22c94cbf93218e5e209f224a5394f1383c398773e21ee1');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `IDSERVICE` int(2) NOT NULL AUTO_INCREMENT,
  `NOM` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`IDSERVICE`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`IDSERVICE`, `NOM`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `absence`
--
ALTER TABLE `absence`
  ADD CONSTRAINT `absence_ibfk_1` FOREIGN KEY (`IDMOTIF`) REFERENCES `motif` (`IDMOTIF`),
  ADD CONSTRAINT `absence_ibfk_2` FOREIGN KEY (`IDPERSONNEL`) REFERENCES `personnel` (`IDPERSONNEL`);

--
-- Contraintes pour la table `personnel`
--
ALTER TABLE `personnel`
  ADD CONSTRAINT `personnel_ibfk_1` FOREIGN KEY (`IDSERVICE`) REFERENCES `service` (`IDSERVICE`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
