-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  Dim 29 mai 2022 à 15:35
-- Version du serveur :  8.0.18
-- Version de PHP :  7.0.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `quentin`
--

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

DROP TABLE IF EXISTS `commande`;
CREATE TABLE IF NOT EXISTS `commande` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(75) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `commande`
--

INSERT INTO `commande` (`id`, `nom`) VALUES
(1, ''),
(2, ''),
(3, 'table5'),
(4, 'table5');

-- --------------------------------------------------------

--
-- Structure de la table `conso`
--

DROP TABLE IF EXISTS `conso`;
CREATE TABLE IF NOT EXISTS `conso` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `conso`
--

INSERT INTO `conso` (`id`, `nom`) VALUES
(1, 'Pizza'),
(2, 'Burger'),
(3, 'Coca'),
(4, 'Ice-tea'),
(5, 'Salade'),
(6, 'pêche au thon'),
(7, 'Eclair chocolat'),
(8, 'Eclair café'),
(9, 'Salade césar'),
(10, 'Pomme de terre sauté '),
(11, 'macarons'),
(12, 'Macarons');

-- --------------------------------------------------------

--
-- Structure de la table `contenir`
--

DROP TABLE IF EXISTS `contenir`;
CREATE TABLE IF NOT EXISTS `contenir` (
  `contenir_commande` int(11) NOT NULL,
  `contenir_conso` int(11) NOT NULL,
  `etat` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`contenir_commande`,`contenir_conso`),
  KEY `id` (`contenir_commande`),
  KEY `contenir_conso` (`contenir_conso`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `contenir`
--

INSERT INTO `contenir` (`contenir_commande`, `contenir_conso`, `etat`) VALUES
(1, 2, 'en cours'),
(1, 3, 'en cours'),
(4, 5, 'en cours');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `contenir`
--
ALTER TABLE `contenir`
  ADD CONSTRAINT `contenir_commande` FOREIGN KEY (`contenir_commande`) REFERENCES `commande` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `contenir_conso` FOREIGN KEY (`contenir_conso`) REFERENCES `conso` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
