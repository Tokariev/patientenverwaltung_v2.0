-- phpMyAdmin SQL Dump
-- version 4.3.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Erstellungszeit: 28. Feb 2019 um 11:20
-- Server-Version: 5.6.24
-- PHP-Version: 5.6.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Datenbank: `patientenverwaltung`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `patienten`
--

CREATE TABLE IF NOT EXISTS `patienten` (
  `id_patient` int(11) NOT NULL,
  `sozialnr` int(11) NOT NULL,
  `name` varchar(255) COLLATE latin1_german1_ci DEFAULT NULL,
  `vorname` varchar(255) COLLATE latin1_german1_ci DEFAULT NULL,
  `geschlecht` varchar(255) COLLATE latin1_german1_ci DEFAULT NULL,
  `adresse` varchar(255) COLLATE latin1_german1_ci DEFAULT NULL,
  `geburtsdatum` date DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1 COLLATE=latin1_german1_ci;

--
-- Daten für Tabelle `patienten`
--

INSERT INTO `patienten` (`id_patient`, `sozialnr`, `name`, `vorname`, `geschlecht`, `adresse`, `geburtsdatum`) VALUES
(1, 3456789, 'abc', 'def', 'ghi', 'straße', '2019-05-30'),
(2, 3456789, 'schäfer', 'albert', 'Männlich', 'hochalpenstraße 5', '1965-03-01'),
(3, 2147483647, 'Herre', 'Markus', 'Männlich', '74360 Auenstein, Schillerstraße 4', '1997-05-30'),
(11, 45608, 'schaust', 'Max', 'Männlich', 'Heilbronn', '1998-06-22'),
(12, 0, 'herbert', 'herrmann', 'Männlich', 'krümelweg', '2019-02-22'),
(13, 99999123, 'einzeltest', 'einzeltest', 'Weiblich', 'einzeltest', '2019-01-31'),
(15, 3456, 'a', 'a', 'Männlich', 'a', '2019-06-12');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `termine`
--

CREATE TABLE IF NOT EXISTS `termine` (
  `id_termin` int(11) NOT NULL,
  `id_patient` int(11) NOT NULL,
  `datum` date NOT NULL,
  `uhrzeit_von` time NOT NULL,
  `uhrzeit_bis` time NOT NULL,
  `betreff` varchar(255) CHARACTER SET latin1 COLLATE latin1_german1_ci NOT NULL,
  `befund` varchar(255) CHARACTER SET latin1 COLLATE latin1_german1_ci DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `termine`
--

INSERT INTO `termine` (`id_termin`, `id_patient`, `datum`, `uhrzeit_von`, `uhrzeit_bis`, `betreff`, `befund`) VALUES
(1, 3, '2019-02-26', '13:33:00', '14:33:00', 'Motorradentzug', 'Motorrad fahren ärztlich verschrieben'),
(2, 12, '2019-02-26', '14:29:00', '15:29:00', 'Entzündung am Arm', ''),
(3, 11, '2019-02-28', '16:30:00', '17:00:00', 'Hundebiss', ''),
(4, 3, '2019-03-01', '08:32:00', '09:32:00', 'abc', '');

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `patienten`
--
ALTER TABLE `patienten`
  ADD PRIMARY KEY (`id_patient`);

--
-- Indizes für die Tabelle `termine`
--
ALTER TABLE `termine`
  ADD PRIMARY KEY (`id_termin`), ADD KEY `FOREIGN_key` (`id_patient`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `patienten`
--
ALTER TABLE `patienten`
  MODIFY `id_patient` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=16;
--
-- AUTO_INCREMENT für Tabelle `termine`
--
ALTER TABLE `termine`
  MODIFY `id_termin` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `termine`
--
ALTER TABLE `termine`
ADD CONSTRAINT `termine_ibfk_1` FOREIGN KEY (`id_patient`) REFERENCES `patienten` (`id_patient`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
