-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 14-05-2022 a las 09:26:23
-- Versión del servidor: 10.4.22-MariaDB
-- Versión de PHP: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `veterinario`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `citas`
--

CREATE TABLE `citas` (
  `codigo_mascota` int(11) NOT NULL,
  `codigo_usuario` int(11) NOT NULL,
  `fecha` varchar(200) NOT NULL,
  `causa` varchar(300) NOT NULL,
  `idCitasUser` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `citas`
--

INSERT INTO `citas` (`codigo_mascota`, `codigo_usuario`, `fecha`, `causa`, `idCitasUser`) VALUES
(1234567, 50042731, '06/07/2022 18:00:00', 'Tercera revisión', 3),
(859366, 50042731, '07/07/2022 15:30:00', 'Revisión', 4),
(859366, 50042731, '13/05/2022 19:00:00', 'Atropello, heridas', 6),
(2756354, 50238442, '19/05/2022 14:45:00', 'Herida en la pata', 1),
(859366, 50042731, '21/05/2022 18:06:34', 'Heridas graves por atropello', 5),
(1234567, 50042731, '28/05/2022 17:49:34', 'Revisión por operación', 2),
(1234567, 50042731, '28/08/2022 18:49:51', 'Revisión rutinariua', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mascota`
--

CREATE TABLE `mascota` (
  `codigoChip` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `tipo` varchar(50) DEFAULT NULL,
  `observaciones` varchar(300) DEFAULT NULL,
  `dni_usuario` int(11) NOT NULL,
  `Sexo` varchar(15) NOT NULL,
  `edad` int(3) NOT NULL,
  `idMascotaUser` int(11) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `mascota`
--

INSERT INTO `mascota` (`codigoChip`, `nombre`, `tipo`, `observaciones`, `dni_usuario`, `Sexo`, `edad`, `idMascotaUser`) VALUES
(859366, 'Perico', 'Loro', 'En rehabilitación por operación.\nVacunas: Sí', 50042731, 'Macho', 2, 2),
(1234567, 'Rocky', 'Perro', 'No tiene ninguna vacuna', 50042731, 'Macho', 1, 1),
(2227534, 'Willy', 'Perro', 'Vacunas: No', 50042731, 'Macho', 3, 3),
(2756354, 'Kira', 'Gato', 'Vacunas: Falta la vacuna del año', 50238442, 'Hembra', 1, 1),
(3455546, 'Manolo', 'Caballo', 'Vacunas: Sí\nPata rota', 50042731, 'Macho', 2, 5),
(5549926, 'Bob', 'Perro', 'Vacuna 1 mes: Realizada.', 50238442, 'Macho', 0, 2),
(7530293, 'Susy', 'Gato', 'Vacunas: Sí\nHerida en la pata.', 50042731, 'Hembra', 3, 4);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trabajador`
--

CREATE TABLE `trabajador` (
  `DNI` varchar(8) NOT NULL,
  `Nombre` varchar(20) NOT NULL,
  `Apellido` varchar(30) NOT NULL,
  `email` varchar(100) NOT NULL,
  `password` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `trabajador`
--

INSERT INTO `trabajador` (`DNI`, `Nombre`, `Apellido`, `email`, `password`) VALUES
('70837762', 'Alfredo', 'García', 'doctorgarcia@clinicaveterinaria.es', '$2a$10$mBnHXkaoDDidNk4OA5WYa.5srXprREu.xWrzAPCPMdoKVNgIXLXce');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `DNI` int(20) NOT NULL,
  `Nombre` varchar(100) COLLATE utf8_bin NOT NULL,
  `Apellido` varchar(100) COLLATE utf8_bin NOT NULL,
  `password` varchar(256) COLLATE utf8_bin NOT NULL,
  `email` varchar(50) COLLATE utf8_bin NOT NULL,
  `perfil` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`DNI`, `Nombre`, `Apellido`, `password`, `email`, `perfil`) VALUES
(50042731, 'Paca', 'Waca', '$2a$10$oJvWNujZ5lUiqHjF19cCtuzOko.d/kvSfUjtHE/ElJgZqxAeTjKE6', 'pacawaca@gmail.com', 5),
(50238442, 'Lucía', 'Martínez', '$2a$10$wfnVNZkv3YL96kje2N6aVuIrqHn5kx6Rru68BJPyhfzzsWxgw4fYu', 'lucimartinez@gmail.com', 2),
(51394029, 'Inés', 'López', '$2a$10$kIhiQ5WtzlWgKOrKzP0G5eRKoORuJ5ttMM7kXbzDuucPKGwAycP3y', 'ineslopez@yahoo.es', 0),
(52278128, 'Sofía', 'Fernández', '$2a$10$LoJXrTFq6l/.Q1PwDOgpN.1T4ZQs2p5ykqddPiaknBuN1sRWC8jkC', 'sofifernandez.sf@gmail.com', 0),
(53672391, 'Marcos', 'Villa', '$2a$10$ZPHKq5lxAxvfWqB/VPMzc./yW.7mpfcvXqSlmCrj.ijkIZ9jIFy5C', 'marcosvilla@gmail.com', 0),
(53745716, 'Pablo', 'Sánchez', '$2a$10$s76xiA3wtPYDpYXSN1ZUcu7zLKWmi7jyG3FjyWRAw0YVYoYj84mIe', 'pablosanchez@yahoo.es', 0),
(53947232, 'Irene', 'Domínguez', '$2a$10$ay775DVeNo6oubUQqjOuCeYkOdiJyvqSDqGJLxBMj32Fi8Wb689CO', 'irene.dominguez@outlook.es', 0),
(53965934, 'Raul', 'Moya', '$2a$10$SDtthQ5ocFgyj0fn0Ik3eOgzeC1LMgQnPcv0mIC8lQoHe8OBTy.4y', 'raulmoya06@gmail.com', 0),
(54458347, 'Pedro', 'Vera', '$2a$10$3gpylmhqsg52GfclcwCttOxUhaNOodY/2LOx9kaxTIbxFiySLr0xy', 'pvera12@gmail.com', 0),
(56128103, 'Claudia', 'González', '$2a$10$kuT/ScNfQBhe9RwS2J3gcen0CIyoBcIYNceUpOMAmsgBGLeEx5Wd.', 'claudiagonzalez@hotmail.com', 0),
(56643561, 'Jorge', 'Benito', '$2a$10$XkVy3s7lpU6vKiGuHHpnPOop9yl11/oKiHUgRo.wqElHv14xS7YSK', 'jorgebenito@yahoo.es', 0),
(56714394, 'Lucas', 'Pons', '$2a$10$k3lQN3NbUpXWRevJcDM0c.Sn/1Bx2/TPMX4eTY9cngF/RewapTFtq', 'lucas27p@gmail.com', 0),
(121345678, 'Alvaro', 'Pemán', '$2a$10$YKTkEC/e9nxMe.foZYFwbOLMeMoGSGOSih4N5VOqQZXf3VUE9fJo.', 'alvaropeman@yahoo.es', 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `citas`
--
ALTER TABLE `citas`
  ADD PRIMARY KEY (`fecha`),
  ADD KEY `codigo_mascota` (`codigo_mascota`),
  ADD KEY `codigo_usuario` (`codigo_usuario`);

--
-- Indices de la tabla `mascota`
--
ALTER TABLE `mascota`
  ADD PRIMARY KEY (`codigoChip`),
  ADD KEY `dni_usuario` (`dni_usuario`);

--
-- Indices de la tabla `trabajador`
--
ALTER TABLE `trabajador`
  ADD PRIMARY KEY (`DNI`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`DNI`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `citas`
--
ALTER TABLE `citas`
  ADD CONSTRAINT `citas_ibfk_1` FOREIGN KEY (`codigo_mascota`) REFERENCES `mascota` (`codigoChip`),
  ADD CONSTRAINT `citas_ibfk_2` FOREIGN KEY (`codigo_usuario`) REFERENCES `usuario` (`DNI`);

--
-- Filtros para la tabla `mascota`
--
ALTER TABLE `mascota`
  ADD CONSTRAINT `mascota_ibfk_1` FOREIGN KEY (`dni_usuario`) REFERENCES `usuario` (`DNI`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
