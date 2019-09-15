-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Czas generowania: 05 Sty 2018, 10:00
-- Wersja serwera: 10.1.19-MariaDB
-- Wersja PHP: 5.6.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `muzeumvr`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `model`
--

CREATE TABLE `model` (
  `id` int(11) NOT NULL COMMENT 'unique id',
  `name` varchar(80) NOT NULL COMMENT 'name of display unit',
  `description` text NOT NULL COMMENT 'description of display unit',
  `filename` varchar(80) NOT NULL COMMENT 'name of file',
  `upload_date` date NOT NULL COMMENT 'upload date',
  `author` varchar(60) NOT NULL COMMENT 'author',
  `year` varchar(20) NOT NULL COMMENT 'date of origin',
  `museum` varchar(50) NOT NULL COMMENT 'museum that object is coming from',
  `verified` tinyint(1) NOT NULL COMMENT 'verify, values 0 or 1'
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COMMENT='table that contains information about all models on the server';

--
-- Zrzut danych tabeli `model`
--

INSERT INTO `Model` (`id`, `name`, `description`, `filename`, `upload_date`, `author`, `year`, `museum`, `verified`) VALUES
(1, 'Lejek', 'Opis lejka', 'lejek', '2018-01-05', 'MuzeumVR', '200 p.n.e.', 'Muzeum VR', 1),
(2, 'Czaszka', 'Opis czaszki', 'czaszka', '2018-01-05', 'MuzeumVR', 'ok. 20 000 r. p.n.e.', 'Muzeum VR', 1),
(3, 'Dzbanek', 'Opis dzbanka.', 'dzbanek', '2018-01-05', 'MuzeumVR', 'VI w.', 'Muzeum VR', 1),
(4, 'Chochla', 'Opis chochli', 'chochla', '2018-01-05', 'MuzeumVR', '200 p.n.e.', 'Muzeum VR', 1),
(5, 'Tabliczka', 'Opis tabliczki.', 'tabliczka', '2018-01-05', 'MuzeumVR', 'nieznany', 'Muzeum VR', 1);
--
-- Indeksy dla zrzutów tabel
--

--
-- Indexes for table `model`
--
ALTER TABLE `model`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `filename` (`filename`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `model`
--
ALTER TABLE `model`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'unique id', AUTO_INCREMENT=5;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
