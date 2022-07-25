-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 25-07-2022 a las 10:32:25
-- Versión del servidor: 10.4.24-MariaDB
-- Versión de PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `testdb`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ajuste`
--

CREATE TABLE `ajuste` (
  `id_ajuste` int(2) NOT NULL,
  `RUT_USUARIO` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `id_tipo_ajuste` int(2) NOT NULL,
  `id_producto` int(2) DEFAULT NULL,
  `cantidad` int(3) NOT NULL,
  `fecha_hora_ajuste` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categoria`
--

CREATE TABLE `categoria` (
  `cod_categoria` int(2) NOT NULL,
  `categoria` varchar(50) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `categoria`
--

INSERT INTO `categoria` (`cod_categoria`, `categoria`) VALUES
(1, 'Fruta'),
(2, 'Oficina'),
(3, 'Papeleria'),
(4, 'Basura');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compra_producto`
--

CREATE TABLE `compra_producto` (
  `id_compra` int(11) NOT NULL,
  `codigo_producto` int(15) NOT NULL,
  `rut_proveedor` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `fecha` datetime DEFAULT NULL,
  `precio_compra` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `deleted_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `compra_producto`
--

INSERT INTO `compra_producto` (`id_compra`, `codigo_producto`, `rut_proveedor`, `fecha`, `precio_compra`, `cantidad`, `deleted_at`) VALUES
(1, 6, '6712534-7', '2022-07-25 01:24:11', 1000, 10, NULL),
(2, 1, '8724231-5', '2022-07-25 01:24:45', 1000, 10, NULL),
(2, 5, '8724231-5', '2022-07-25 01:24:45', 100, 10, NULL),
(2, 10, '8724231-5', '2022-07-25 01:24:43', 100, 10, NULL),
(2, 11, '8724231-5', '2022-07-25 01:24:44', 100, 10, '2022-07-25 01:37:42');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE `producto` (
  `id_producto` int(3) NOT NULL,
  `cod_categoria` int(2) NOT NULL,
  `nombre` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `descripcion` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `precio_por_detalle` int(6) NOT NULL,
  `precio_por_mayor` int(6) NOT NULL,
  `stock` int(3) NOT NULL,
  `deleted_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`id_producto`, `cod_categoria`, `nombre`, `descripcion`, `precio_por_detalle`, `precio_por_mayor`, `stock`, `deleted_at`) VALUES
(1, 1, 'Membrillo', 'asdf', 1000, 500, 9, NULL),
(2, 1, 'Manzana', '', 900, 500, 100, NULL),
(3, 1, 'Platano', '', 1000, 500, 70, NULL),
(4, 1, 'Naranja', '', 1500, 1000, 42, NULL),
(5, 1, 'Mandarina', '', 1500, 1000, 70, NULL),
(6, 1, 'Pepino', '', 1234, 33, 42, NULL),
(7, 2, 'Lapiz', '', 500, 300, 90, NULL),
(8, 3, 'Agenda', '', 3000, 2500, 100, '2022-07-24 16:49:48'),
(9, 1, 'Papel', 'asdfsa', 1000, 990, 100, '2022-07-24 17:13:15'),
(10, 1, 'jdskajdk', 'jsdkadjask', 1000, 999, 120, NULL),
(11, 1, 'Palta', 'de oro', 1392, 1033, 83, NULL),
(12, 1, 'pesadask', 'sjfiajsfo', 100, 99, 1000, '2022-07-24 17:27:10');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE `proveedor` (
  `rut_proveedor` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `nombre` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `direccion` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `celular` int(9) NOT NULL,
  `deleted_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`rut_proveedor`, `nombre`, `direccion`, `celular`, `deleted_at`) VALUES
('6712534-7', 'Enrique', 'Pumanque 1921', 967952135, NULL),
('8724231-5', 'Marisol', 'Pumanque 1921', 967952136, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_ajuste`
--

CREATE TABLE `tipo_ajuste` (
  `id_tipo_ajuste` int(2) NOT NULL,
  `tipo_ajuste` varchar(50) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `tipo_ajuste`
--

INSERT INTO `tipo_ajuste` (`id_tipo_ajuste`, `tipo_ajuste`) VALUES
(1, 'Modificación Producto'),
(2, 'Inserción Producto'),
(3, 'Eliminación Producto');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_usuario`
--

CREATE TABLE `tipo_usuario` (
  `id_tipo_usuario` int(1) NOT NULL,
  `nombre_tipo_usuario` varchar(10) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `tipo_usuario`
--

INSERT INTO `tipo_usuario` (`id_tipo_usuario`, `nombre_tipo_usuario`) VALUES
(1, 'admin'),
(2, 'user');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `RUT_USUARIO` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `ID_TIPO_USUARIO` int(1) NOT NULL,
  `NOMBRE_USUARIO` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `APELLIDO_USUARIO` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `CONTRASENA` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `deleted_at` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`RUT_USUARIO`, `ID_TIPO_USUARIO`, `NOMBRE_USUARIO`, `APELLIDO_USUARIO`, `CONTRASENA`, `deleted_at`) VALUES
('19308210-6', 1, 'Itiel', 'Toledo', 'z+BS+7lucqrSTpBK7EQiRA==', NULL),
('8724231-5', 2, 'Marisol', 'Retamales', 'OVeaZjavxtmakrfAJng0LA==', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta_producto`
--

CREATE TABLE `venta_producto` (
  `id_venta` int(11) NOT NULL,
  `codigo_producto` int(11) NOT NULL,
  `rut_usuario` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `precio_venta` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `fecha` datetime NOT NULL,
  `deleted_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Volcado de datos para la tabla `venta_producto`
--

INSERT INTO `venta_producto` (`id_venta`, `codigo_producto`, `rut_usuario`, `precio_venta`, `cantidad`, `fecha`, `deleted_at`) VALUES
(1, 2, '8724231-5', 900, 10, '2022-07-25 03:29:24', '2022-07-25 04:26:57');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `ajuste`
--
ALTER TABLE `ajuste`
  ADD PRIMARY KEY (`id_ajuste`),
  ADD KEY `id_producto` (`id_producto`),
  ADD KEY `ajuste_ibfk_3` (`id_tipo_ajuste`),
  ADD KEY `RUT_USUARIO` (`RUT_USUARIO`);

--
-- Indices de la tabla `categoria`
--
ALTER TABLE `categoria`
  ADD PRIMARY KEY (`cod_categoria`);

--
-- Indices de la tabla `compra_producto`
--
ALTER TABLE `compra_producto`
  ADD PRIMARY KEY (`id_compra`,`codigo_producto`,`rut_proveedor`),
  ADD KEY `rut_proveedor` (`rut_proveedor`),
  ADD KEY `codigo_producto` (`codigo_producto`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`id_producto`),
  ADD KEY `cod_categoria` (`cod_categoria`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`rut_proveedor`);

--
-- Indices de la tabla `tipo_ajuste`
--
ALTER TABLE `tipo_ajuste`
  ADD PRIMARY KEY (`id_tipo_ajuste`);

--
-- Indices de la tabla `tipo_usuario`
--
ALTER TABLE `tipo_usuario`
  ADD PRIMARY KEY (`id_tipo_usuario`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`RUT_USUARIO`),
  ADD KEY `ID_TIPO_USUARIO` (`ID_TIPO_USUARIO`);

--
-- Indices de la tabla `venta_producto`
--
ALTER TABLE `venta_producto`
  ADD PRIMARY KEY (`id_venta`,`codigo_producto`,`rut_usuario`),
  ADD KEY `rut_usuario` (`rut_usuario`),
  ADD KEY `codigo_producto` (`codigo_producto`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `ajuste`
--
ALTER TABLE `ajuste`
  ADD CONSTRAINT `ajuste_ibfk_3` FOREIGN KEY (`id_tipo_ajuste`) REFERENCES `tipo_ajuste` (`id_tipo_ajuste`) ON UPDATE CASCADE,
  ADD CONSTRAINT `ajuste_ibfk_4` FOREIGN KEY (`RUT_USUARIO`) REFERENCES `usuario` (`RUT_USUARIO`);

--
-- Filtros para la tabla `compra_producto`
--
ALTER TABLE `compra_producto`
  ADD CONSTRAINT `compra_producto_ibfk_1` FOREIGN KEY (`rut_proveedor`) REFERENCES `proveedor` (`rut_proveedor`),
  ADD CONSTRAINT `compra_producto_ibfk_2` FOREIGN KEY (`codigo_producto`) REFERENCES `producto` (`id_producto`);

--
-- Filtros para la tabla `producto`
--
ALTER TABLE `producto`
  ADD CONSTRAINT `producto_ibfk_1` FOREIGN KEY (`cod_categoria`) REFERENCES `categoria` (`cod_categoria`);

--
-- Filtros para la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`ID_TIPO_USUARIO`) REFERENCES `tipo_usuario` (`id_tipo_usuario`);

--
-- Filtros para la tabla `venta_producto`
--
ALTER TABLE `venta_producto`
  ADD CONSTRAINT `venta_producto_ibfk_1` FOREIGN KEY (`rut_usuario`) REFERENCES `usuario` (`RUT_USUARIO`),
  ADD CONSTRAINT `venta_producto_ibfk_2` FOREIGN KEY (`codigo_producto`) REFERENCES `producto` (`id_producto`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
