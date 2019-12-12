-- phpMyAdmin SQL Dump
-- version 4.8.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jun 21, 2018 at 06:08 PM
-- Server version: 8.0.11
-- PHP Version: 7.0.30-0ubuntu0.16.04.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `billydb`
--

-- --------------------------------------------------------

--
-- Table structure for table `Brand`
--

CREATE TABLE `Brand` (
  `name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `Brand`
--

INSERT INTO `Brand` (`name`) VALUES
('8020/Tough'),
('Salad'),
('Salad/8020/Tough');

-- --------------------------------------------------------

--
-- Table structure for table `product_return`
--

CREATE TABLE `product_return` (
  `invoice_id` varchar(255) NOT NULL,
  `brand` varchar(255) NOT NULL,
  `pid` varchar(255) NOT NULL,
  `short_code` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `color` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `size` varchar(255) DEFAULT NULL,
  `quantity` int(255) NOT NULL,
  `price` varchar(255) DEFAULT NULL,
  `found` int(1) DEFAULT '0',
  `packed` int(1) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `product_return`
--

INSERT INTO `product_return` (`invoice_id`, `brand`, `pid`, `short_code`, `color`, `size`, `quantity`, `price`, `found`, `packed`) VALUES
('001', 'Salad', '501218C432916326', '43291', '83-LBL', '26', 1, NULL, 0, 0),
('001', 'Salad', '501218C466896904', '46689', '69-DNY', '4', 1, NULL, 0, 0),
('001', 'Salad', '501218G232686305', '23268', '63-LBL', '5', 1, NULL, 0, 0),
('001', 'Salad', '501218G250772305', '25077', '23-LPK', '5', 1, NULL, 0, 0),
('001', 'Salad', '501218G250982305', '25098', '23-LPK', '5', 1, NULL, 0, 0),
('001', 'Salad', '501218G338303105', '33830', '31-LHG', '5', 1, NULL, 0, 0),
('001', 'Salad', '501218G338391305', '33839', '13-IVY', '5', 1, NULL, 0, 0),
('001', 'Salad', '501218G338742305', '33874', '23-LPK', '5', 1, NULL, 0, 0),
('001', 'Salad', '501218G466956005', '46695', '60-BLE', '5', 1, NULL, 0, 0),
('002', 'Salad', '601218G039590100', NULL, NULL, NULL, 1, '$2250', 0, 0),
('002', 'Salad', '601218G039592700', NULL, NULL, NULL, 1, '$2250', 0, 0),
('003', 'Salad', '501218G339300104', NULL, NULL, NULL, 1, '$650', 0, 0),
('004', 'Salad', '601218C039138900', '03913', '89-TOF', '00', 1, NULL, 1, 1),
('004', 'Salad', '601218D039690100', '03969', '01-BLK', '00', 1, NULL, 1, 0),
('004', 'Salad', '601218F001950200', '00195', '02-SIL', '00', 1, NULL, 1, 1),
('004', 'Salad', '601218FAA1212500', 'AA121', '25-PNK', '00', 1, NULL, 1, 0),
('004', 'Salad', '601218FAB1830200', 'AB183', '02-SIL', '00', 1, NULL, 1, 1),
('004', 'Salad', '601218GAA1382300', 'AA138', '23-LPK', '00', 1, NULL, 0, 0),
('005', 'Salad', '601217G960041300', '96004', '13-IVY', '00', 1, NULL, 0, 0),
('005', 'Salad', '601217G960042300', '96004', '23-LPK', '00', 1, NULL, 1, 1),
('005', 'Salad', '601217N039357300', '03935', '73-ORC', '00', 1, NULL, 1, 1),
('005', 'Salad', '601218G030586300', '03058', '63-LBL', '00', 1, NULL, 1, 1),
('005', 'Salad', '601218G030602300', '03060', '23-LPK', '00', 1, NULL, 1, 1),
('005', 'Salad', '601218G031322500', '03132', '25-PNK', '00', 1, NULL, 1, 1),
('005', 'Salad', '601218G031325100', '03132', '51-PGN', '00', 1, NULL, 1, 1),
('005', 'Salad', '601218G031326500', '03132', '65-SBL', '00', 1, NULL, 1, 1),
('005', 'Salad', '601218G031327300', '03132', '73-ORC', '00', 1, NULL, 1, 1),
('006', 'Salad', '501218A403850125', NULL, NULL, NULL, 1, NULL, 1, 1),
('006', 'Salad', '501218D039656900', NULL, NULL, NULL, 1, NULL, 1, 1),
('006', 'Salad', '501218G330791304', NULL, NULL, NULL, 1, NULL, 1, 1),
('006', 'Salad', '601218G030810100', NULL, NULL, NULL, 1, NULL, 1, 1),
('006', 'Salad', '601218G030826900', NULL, NULL, NULL, 1, NULL, 1, 1),
('007', 'Salad', '601218E057786900', '05778', '69-DNY', '00', 1, NULL, 0, 0),
('008', 'Salad', '501216G615970104', '61597', '01-BLK', '04', 1, NULL, 1, 0),
('008', 'Salad', '501218C615640104', '61564', '01-BLK', '04', 1, NULL, 1, 0),
('008', 'Salad', '501218G467091304', '46709', '13-VY', '04', 1, NULL, 1, 1),
('008', 'Salad', '501218G467176304', '46717', '63-LBL', '04', 1, NULL, 0, 0),
('008', 'Salad', '501218G615891304', '61589', '13-IVY', '04', 1, NULL, 0, 0),
('008', 'Salad', '601218GAB2214400', 'AB221', '44-YLW', '00', 1, NULL, 1, 1),
('009', 'Salad', '501218G615933305', NULL, NULL, NULL, 1, '$695', 1, 0),
('009', 'Salad', '501218G61595015', NULL, NULL, NULL, 1, '$695', 1, 0),
('009', 'Salad', '501218G704000104', NULL, NULL, NULL, 1, '$595', 1, 0),
('009', 'Salad', '601217G007762700', NULL, NULL, NULL, 1, '$750', 0, 0),
('009', 'Salad', '601217NAA1422300', NULL, NULL, NULL, 1, '$450', 0, 0),
('009', 'Salad', '601217NAA1427400', NULL, NULL, NULL, 1, '$450', 1, 1),
('009', 'Salad', '601218F057816300', NULL, NULL, NULL, 1, '$695', 0, 0),
('009', 'Salad', '601218F057816900', NULL, NULL, NULL, 1, '$695', 1, 1),
('009', 'Salad', '601218G002237300', NULL, NULL, NULL, 1, '$895', 0, 0),
('009', 'Salad', '601218G002392700', NULL, NULL, NULL, 1, '$650', 0, 0),
('009', 'Salad', '601218G030596900', NULL, NULL, NULL, 1, '$2490', 1, 1),
('009', 'Salad', '601218G030696600', NULL, NULL, NULL, 1, '$2390', 1, 1),
('009', 'Salad', '601218GAA1373300', NULL, NULL, NULL, 1, '$450', 1, 1),
('009', 'Salad', '601218GAA1392500', NULL, NULL, NULL, 1, '$495', 0, 0),
('009', 'Salad', '601218GAB2142500', NULL, NULL, NULL, 1, '$795', 0, 0),
('009', 'Salad', '601218GAB2242700', NULL, NULL, NULL, 1, '$765', 0, 0),
('010', 'Salad', '501218G433006425', '43300', '64-ENZ', '25', 1, NULL, 1, 0),
('010', 'Salad', '501218G433016425', '43301', '64-ENZ', '25', 1, NULL, 1, 1),
('011', '8020/Tough', '101218C432806425', '43280', '64-ENZ', '25', 1, NULL, 0, 0),
('011', '8020/Tough', '101218D466866904', '46686', '69-DNY', '04', 1, NULL, 1, 1),
('011', '8020/Tough', '101218G339421304', '33942', '13-IVY', '04', 1, NULL, 1, 0),
('011', '8020/Tough', '101218G339441304', '33944', '13-IVY', '04', 1, NULL, 1, 1),
('011', '8020/Tough', '101218G339450104', '33945', '01-BLK', '04', 1, NULL, 1, 1),
('011', '8020/Tough', '101218G404256426', '40425', '64-ENZ', '26', 1, NULL, 1, 1),
('011', '8020/Tough', '101218G432949925', '43294', '99-CHA', '25', 1, NULL, 1, 1),
('011', '8020/Tough', '101218G456616426', '45661', '64-ENZ', '26', 1, NULL, 1, 0),
('011', '8020/Tough', '201217N037700100', '03770', '01-BLK', '00', 1, NULL, 1, 1),
('011', '8020/Tough', '201218G030492500', '03049', '25-PNK', '00', 1, NULL, 1, 1),
('011', '8020/Tough', '201218G038390100', '03839', '01-BLK', '00', 1, NULL, 0, 0),
('011', '8020/Tough', 'K01218G330181204', '33018', '12-WW', '04', 1, NULL, 1, 1),
('011', '8020/Tough', 'K01218G339631204', '33963', '12-WW', '04', 1, NULL, 1, 1),
('012', '8020/Tough', '201218A039190100', '03919', '01-BLK', '00', 1, NULL, 0, 0),
('012', '8020/Tough', '201218G030460100', '03046', '01-BLK', '00', 1, NULL, 1, 1),
('012', '8020/Tough', '201218G030482500', '03048', '25-PNK', '00', 1, NULL, 1, 1),
('012', '8020/Tough', '201218G030490100', '03049', '01-BLK', '00', 1, NULL, 0, 0),
('012', '8020/Tough', '201218G030500100', '03050', '01-BLK', '00', 1, NULL, 1, 1),
('012', '8020/Tough', 'A01218B030146900', '03014', '69-DNY', '00', 1, NULL, 0, 0),
('012', '8020/Tough', 'A01218G030750100', '03075', '01-BLK', '00', 1, NULL, 0, 0),
('012', '8020/Tough', 'A01218G039871200', '03987', '12-WW', '00', 1, NULL, 0, 0),
('012', '8020/Tough', 'K01218A213176004', '21317', '60-BLE', '04', 1, NULL, 0, 0),
('012', '8020/Tough', 'K01218A404116826', '40411', '68-IDG', '26', 1, NULL, 0, 0),
('012', '8020/Tough', 'K01218A404120127', '40412', '01-BLK', '27', 1, NULL, 0, 0),
('012', '8020/Tough', 'K01218B337830104', '33785', '01-BLK', '04', 1, NULL, 0, 0),
('012', '8020/Tough', 'K01218C337872504', '33787', '25-PNK', '04', 1, NULL, 0, 0),
('012', '8020/Tough', 'K01218C339581204', '33958', '12-WW', '04', 1, NULL, 0, 0),
('012', '8020/Tough', 'K01218C404756827', '40475', '68-IDG', '27', 1, NULL, 0, 0),
('012', '8020/Tough', 'K01218G338721204', '33872', '12-WW', '04', 1, NULL, 0, 0),
('012', '8020/Tough', 'K01218G339620104', '33962', '01-BLK', '04', 1, NULL, 0, 0),
('012', '8020/Tough', 'K01218G703860104', '70386', '01-BLK', '04', 1, NULL, 1, 1),
('013', '8020/Tough', 'A01118C048910100', '04891', '01-BLK', '00', 1, NULL, 0, 0),
('013', '8020/Tough', 'A01118G031060100', '03106', '01-BLK', '00', 1, NULL, 0, 0),
('013', '8020/Tough', 'K01118B404106832', '40410', '68-IDG', '32', 1, NULL, 0, 0),
('013', '8020/Tough', 'K01118B703616904', '70361', '69-DNY', '04', 1, NULL, 1, 1),
('013', '8020/Tough', 'K01118G330209305', '33020', '93-LGY', '05', 1, NULL, 0, 0),
('013', '8020/Tough', 'K01118G330226905', '33022', '69-DNY', '05', 1, NULL, 0, 0),
('013', '8020/Tough', 'K01118G339590105', '33959', '01-BLK', '05', 1, NULL, 1, 1),
('013', '8020/Tough', 'K01118G339651205', '33965', '12-VWV', '05', 1, NULL, 1, 1),
('013', '8020/Tough', 'K01118G432936832', '43293', '68-IDG', '32', 1, NULL, 1, 0),
('013', '8020/Tough', 'K01218G339610104', '33961', '01-BLK', '04', 1, NULL, 1, 1),
('013', '8020/Tough', 'K01218G339631204', '33963', '12-WW', '04', 1, NULL, 0, 0),
('013', '8020/Tough', 'K01218G339640104', '33964', '01-BLK', '04', 1, NULL, 1, 1),
('013', '8020/Tough', 'K01218G342861204', '34286', '12-WW', '04', 1, NULL, 1, 1),
('013', '8020/Tough', 'K01218G432920126', '43292', '01-BLK', '26', 1, NULL, 0, 0),
('013', '8020/Tough', 'K01218G703870104', '70387', '01-BLK', '04', 1, NULL, 1, 1),
('014', '8020/Tough', '201218A039190100', '03919', '01-BLK', '00', 1, NULL, 0, 0),
('014', '8020/Tough', '201218G030460100', '03046', '01-BLK', '00', 1, NULL, 0, 0),
('014', '8020/Tough', '201218G030482500', '03048', '25-PNK', '00', 1, NULL, 0, 0),
('014', '8020/Tough', '201218G030490100', '03049', '01-BLK', '00', 1, NULL, 0, 0),
('014', '8020/Tough', '201218G030500100', '03050', '01-BLK', '00', 1, NULL, 0, 0),
('014', '8020/Tough', 'A01218G039871200', '03987', '12-WW', '00', 1, NULL, 0, 0),
('015', '8020/Tough', '201117G160238800', NULL, NULL, NULL, 1, '$260 ', 0, 0),
('015', '8020/Tough', '201117G160241900', NULL, NULL, NULL, 1, '$290 ', 0, 0),
('015', '8020/Tough', '201117H991060100', NULL, NULL, NULL, 1, '$250 ', 0, 0),
('015', '8020/Tough', '201118AAA080100', NULL, NULL, NULL, 1, '$350 ', 0, 0),
('015', '8020/Tough', '201118B960140100', NULL, NULL, NULL, 1, '$380 ', 1, 1),
('015', '8020/Tough', '201118C960760600', NULL, NULL, NULL, 1, '$330 ', 0, 0),
('015', '8020/Tough', '201118D001978700', NULL, NULL, NULL, 1, '$750 ', 0, 0),
('015', '8020/Tough', '201118D001990100', NULL, NULL, NULL, 1, '$790 ', 0, 0),
('015', '8020/Tough', '201118DAB1890100', NULL, NULL, NULL, 1, '$540 ', 0, 0),
('015', '8020/Tough', '201118E002020100', NULL, NULL, NULL, 1, '$600 ', 0, 0),
('015', '8020/Tough', '201118E030040100', NULL, NULL, NULL, 1, '$1,260 ', 0, 0),
('015', '8020/Tough', '201118E030060100', NULL, NULL, NULL, 1, '$1,690 ', 0, 0),
('015', '8020/Tough', '201118E960770100', NULL, NULL, NULL, 1, '$535 ', 0, 0),
('015', '8020/Tough', '201118G038450100', NULL, NULL, NULL, 1, '$1,390 ', 0, 0),
('015', '8020/Tough', '201118G038470100', NULL, NULL, NULL, 1, '$2,480 ', 0, 0),
('015', '8020/Tough', '201118GAB2280100', NULL, NULL, NULL, 1, '$830 ', 0, 0),
('015', '8020/Tough', '201218D991560280', NULL, NULL, NULL, 1, '$290 ', 0, 0),
('015', '8020/Tough', '201218D991572100', NULL, NULL, NULL, 1, '$290 ', 0, 0),
('015', '8020/Tough', '201218DAA1172500', NULL, NULL, NULL, 1, '$495 ', 0, 0),
('015', '8020/Tough', '201218G002240100', NULL, NULL, NULL, 1, '$790 ', 0, 0),
('015', '8020/Tough', '201218G030492500', NULL, NULL, NULL, 1, '$1,490 ', 1, 1),
('015', '8020/Tough', '201218G960450100', NULL, NULL, NULL, 1, '$390 ', 1, 0),
('015', '8020/Tough', '201218GAB1270100', NULL, NULL, NULL, 1, '$590 ', 0, 0),
('016', '8020/Tough', '101218C432806426', '43280', '64-ENZ', '26', 1, NULL, 1, 0),
('016', '8020/Tough', '101218G339416904', '33941', '69-DNY', '04', 1, NULL, 1, 1),
('016', '8020/Tough', '101218G339450104', '33945', '01-BLK', '04', 1, NULL, 1, 1),
('016', '8020/Tough', '101218G432976426', '43297', '64-ENZ', '26', 1, NULL, 1, 0),
('016', '8020/Tough', '201218G030560100', '03056', '01-BLK', '00', 1, NULL, 0, 0),
('016', '8020/Tough', '201218G030570100', '03057', '01-BLK', '00', 1, NULL, 1, 1),
('016', '8020/Tough', '701218A404240104', '40424', '01-BLK', '04', 1, NULL, 0, 0),
('016', '8020/Tough', '701218G251330104', '25133', '01-BLK', '04', 1, NULL, 0, 0),
('016', '8020/Tough', '701218G338680104', '33868', '01-BLK', '04', 1, NULL, 0, 0),
('016', '8020/Tough', '701218G338870104', '33887', '01-BLK', '04', 1, NULL, 0, 0),
('016', '8020/Tough', '701218G338900105', '33890', '01-BLK', '05', 1, NULL, 0, 0),
('016', '8020/Tough', '701218G339810105', '33981', '01-BLK', '05', 1, NULL, 0, 0),
('016', '8020/Tough', '701218G342880199', '34288', '01-BLK', '99', 1, NULL, 0, 0),
('016', '8020/Tough', '701218G432950105', '43295', '01-BLK', '05', 1, NULL, 0, 0),
('016', '8020/Tough', '701218G615810199', '61581', '01-BLK', '99', 1, NULL, 0, 0),
('016', '8020/Tough', '701218G703800104', '70380', '01-BLK', '04', 1, NULL, 0, 0),
('016', '8020/Tough', 'K01218C404746826', '40474', '68-IDG', '26', 1, NULL, 1, 1),
('016', '8020/Tough', 'K01218G213370104', '21337', '01-BLK', '04', 1, NULL, 0, 0),
('016', '8020/Tough', 'K01218G330280104', '33028', '01-BLK', '04', 1, NULL, 1, 1),
('016', '8020/Tough', 'K01218G339640104', '33964', '01-BLK', '04', 1, NULL, 0, 0),
('017', '8020/Tough', '101118G330090105', '33009', '01-BLK', '05', 1, NULL, 0, 0),
('017', '8020/Tough', '101118G403416032', '40341', '60-BLE', '32', 1, NULL, 0, 0),
('017', '8020/Tough', '101118G426936432', '42693', '64-ENZ', '32', 1, NULL, 0, 0),
('017', '8020/Tough', '101118G426969932', '42696', '99CHA', '32', 1, NULL, 0, 0),
('017', '8020/Tough', '101118G426976832', '42697', '68-IDG', '32', 1, NULL, 0, 0),
('017', '8020/Tough', '101118G703820105', '70382', '01-BLK', '05', 1, NULL, 1, 1),
('017', '8020/Tough', '101218G323959904', '32395', '99-CHA', '04', 1, NULL, 0, 0),
('017', '8020/Tough', '101218G339140104', '33914', '01-BLK', '04', 1, NULL, 1, 1),
('017', '8020/Tough', '101218G339319904', '33991', '99-CHA', '04', 1, NULL, 0, 0),
('017', '8020/Tough', '101218G339500104', '33950', '01-BLK', '04', 1, NULL, 0, 0),
('017', '8020/Tough', '101218N433100125', '43310', '01-BLK', '25', 1, NULL, 1, 1),
('018', '8020/Tough', '101118C426831905', '42683', '19-ARM', '05', 1, NULL, 0, 0),
('018', '8020/Tough', '101118G330051105', '33005', '11-WHT', '05', 1, NULL, 1, 1),
('018', '8020/Tough', '101118G330120105', '33012', '01-BLK', '05', 1, NULL, 0, 0),
('018', '8020/Tough', '101118G330370105', '38037', '01-BLK', '05', 1, NULL, 0, 0),
('018', '8020/Tough', '101118G330414405', '33941', '44-YLW', '05', 1, NULL, 0, 0),
('018', '8020/Tough', '101118G339100105', '33910', '01-BLK', '05', 1, NULL, 1, 1),
('018', '8020/Tough', '101118G703840105', '70384', '01-BLK', '05', 1, NULL, 1, 1),
('018', '8020/Tough', '101218G338650104', '33865', '01-BLK', '04', 1, NULL, 1, 1),
('018', '8020/Tough', '101218G437960125', '43296', '01-BLK', '25', 1, NULL, 0, 0),
('018', '8020/Tough', '101218G456679925', '45667', '99-CHA', '25', 1, NULL, 0, 0),
('018', '8020/Tough', '101218G616089904', '61608', '99-CHA', '04', 1, NULL, 0, 0),
('018', '8020/Tough', '101218G703930104', '70393', '01-BLK', '04', 1, NULL, 0, 0),
('018', '8020/Tough', 'TUM1181337765305', '33776', '53-GRN', '05', 1, NULL, 1, 1),
('018', '8020/Tough', 'TUM1181337811205', '33781', '12-WW', '05', 1, NULL, 0, 0),
('019', '8020/Tough', '1011180205996006', '20599', '60-BLE', '06', 1, NULL, 0, 0),
('019', '8020/Tough', '1011188337346805', '33734', '68-IDG', '05', 1, NULL, 0, 0),
('019', '8020/Tough', '101118C206006406', '20600', '64-ENZ', '06', 1, NULL, 0, 0),
('019', '8020/Tough', '101118C403626832', '40362', '68-1DG', '32', 1, NULL, 0, 0),
('019', '8020/Tough', '101118G206099006', '20609', '90-GRY', '06', 1, NULL, 0, 0),
('019', '8020/Tough', '201118G049066000', '04906', '60-BLE', '00', 1, NULL, 0, 0),
('019', '8020/Tough', '201118G049076000', '04907', '60-BLE', '00', 1, NULL, 0, 0),
('019', '8020/Tough', 'A01118A048870100', '04887', '01-8LK', '00', 1, NULL, 0, 0),
('019', '8020/Tough', 'A01118A048871900', '04887', '19-ARM', '00', 1, NULL, 0, 0),
('019', '8020/Tough', 'K01118C337840106', '33784', '01-BLK', '06', 1, NULL, 0, 0),
('019', '8020/Tough', 'K01118C404430132', '40443', '01-BLK', '32', 1, NULL, 0, 0),
('019', '8020/Tough', 'K01118C404716832', '40471', '68-IDG', '32', 1, NULL, 1, 1),
('019', '8020/Tough', 'K01118G330210106', '33021', '01-BLK', '06', 1, NULL, 1, 1),
('019', '8020/Tough', 'K01118G338840105', '33884', '01-BLK', '05', 1, NULL, 0, 0),
('019', '8020/Tough', 'K01118G338860105', '33886', '01-BLK', '05', 1, NULL, 1, 1),
('019', '8020/Tough', 'K01118G404800132', '40480', '01-BLK', '32', 1, NULL, 0, 0),
('019', '8020/Tough', 'K01118G432936832', '43293', '68-IDG', '32', 1, NULL, 0, 0),
('019', '8020/Tough', 'K01118G703781906', '70378', '19-ARM', '06', 1, NULL, 1, 1),
('019', '8020/Tough', 'KU1118A404086832', '40408', '68-IDG', '32', 1, NULL, 1, 1),
('019', '8020/Tough', 'TUM1181410748406', '41074', '84-KHA', '06', 1, NULL, 1, 1),
('020', 'Salad', '501218C433060126', '43306', '01-BLK', '26', 1, NULL, 0, 0),
('020', 'Salad', '501218G330851104', '33085', '11-WHT', '04', 1, NULL, 1, 0),
('020', 'Salad', '501218G330939704', '33093', '97-MGY', '04', 1, NULL, 0, 0),
('020', 'Salad', '501218G331112704', '33111', '27-RED', '04', 1, NULL, 1, 0),
('020', 'Salad', '501218G338920104', '33892', '01-BLK', '04', 1, NULL, 1, 0),
('020', 'Salad', '501218G338962304', '33896', '23-LPK', '04', 1, NULL, 1, 1),
('020', 'Salad', '501218G339752304', '33975', '23-LPK', '04', 1, NULL, 1, 0),
('020', 'Salad', '501218G433046427', '43304', '64-ENZ', '27', 1, NULL, 1, 0),
('020', 'Salad', '501218G703590105', '70359', '01-BLK', '05', 1, NULL, 1, 0),
('020', 'Salad', '501218G703670105', '70367', '01-BLK', '05', 1, NULL, 1, 0),
('020', 'Salad', '601218A039502700', '03950', '27-RED', '00', 1, NULL, 1, 1),
('020', 'Salad', '601218D039681100', '03968', '11-WHT', '00', 1, NULL, 1, 1),
('020', 'Salad', '601218G002462500', '00246', '25-PNK', '00', 1, NULL, 1, 1),
('020', 'Salad', '601218G002586500', '00258', '65-SBL', '00', 1, NULL, 1, 1),
('020', 'Salad', '601218G030351100', '03035', '11-WHT', '00', 1, NULL, 1, 1),
('020', 'Salad', '601218G030636100', '03063', '61-SLB', '00', 1, NULL, 1, 1),
('020', 'Salad', '601218G039546100', '03954', '61-SLB', '00', 1, NULL, 1, 1),
('020', 'Salad', '601218G960982500', '96098', '25-PNK', '00', 1, NULL, 1, 1),
('020', 'Salad', '601218GAB2372500', 'AB237', '25-PNK', '00', 1, NULL, 1, 1),
('020', 'Salad', '601218GAB2576500', 'AB257', '65-SBL', '00', 1, NULL, 1, 1),
('021', 'Salad/8020/Tough', '101118G330414405', '33041', '44-YLW', '05', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '101218H433146327', '43314', '63-LBL', '27', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '101218N433126427', '43312', '64-ENZ', '27', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '201118F002030100', '00203', '01-BLK', '00', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '201118N049110100', '04911', '01-BLK', '00', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '201118N049120100', '04912', '01-BLK', '00', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '201217N991490600', '99149', '06-RBO', '00', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '201218D039920100', '03992', '01-BLK', '00', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '5012180330752304', '33975', '23-LPK', '04', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '501218G339730104', '33973', '01-BLK', '04', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '601216E160164400', '16016', '44-YLW', '00', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '601216N004956300', '00495', '63-LBL', '00', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '601216N004957300', '00495', '73-ORC', '00', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '601216N005142300', '00514', '23-LPK', '00', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '601217IAA0192500', 'AA019', '25-PNK', '00', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '601217IAA0202700', 'AA020', '27-RED', '00', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '601217N039381300', '03938', '13-IVY', '00', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '601218E001886500', '00188', '65-SBL', '00', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '601218F001919300', '00191', '93-LGY', '00', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '601218F001950200', '00195', '02-SIL', '00', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '601218FAB1830200', 'AB183', '02-SIL', '00', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '601218G002582300', '00258', '23-LPK', '00', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '601218G002592300', '00259', '23-LPK', '00', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '601218NAA1491100', 'AA149', '11-WHT', '00', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', '601218NAA1500100', 'AA150', '01-BLK', '00', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', 'K01118G332280105', '33228', '01-BLK', '05', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', 'K01118H331320105', '33132', '01-BLK', '05', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', 'K01118H331361205', '33136', '12-WW', '05', 1, NULL, 0, 0),
('021', 'Salad/8020/Tough', 'K01118N331700105', '33170', '01-BLK', '05', 1, NULL, 0, 0),
('022', 'Salad', '501218G338962304', NULL, NULL, NULL, 1, NULL, 1, 0),
('022', 'Salad', '501218G339401305', NULL, NULL, NULL, 1, '$395', 1, 1),
('022', 'Salad', '501218G433016426', NULL, NULL, NULL, 1, NULL, 1, 1),
('022', 'Salad', '501218G433036327', NULL, NULL, NULL, 1, '$575', 1, 1),
('022', 'Salad', '501218G467296904', NULL, NULL, NULL, 1, NULL, 1, 1),
('022', 'Salad', '501218G467321304', NULL, NULL, NULL, 1, NULL, 1, 1),
('023', '8020/Tough', 'A01118B048890100', '04889', '01-BLK', '00', 1, NULL, 0, 0),
('099', '8020/Tough', 'asddddasdsadasa', 'aaa', 'asd', 'asd', 1, NULL, 0, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Brand`
--
ALTER TABLE `Brand`
  ADD PRIMARY KEY (`name`);

--
-- Indexes for table `product_return`
--
ALTER TABLE `product_return`
  ADD PRIMARY KEY (`invoice_id`,`pid`),
  ADD KEY `brand_fk1` (`brand`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `product_return`
--
ALTER TABLE `product_return`
  ADD CONSTRAINT `brand_fk1` FOREIGN KEY (`brand`) REFERENCES `Brand` (`name`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;