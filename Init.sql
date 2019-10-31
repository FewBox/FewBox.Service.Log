USE log;
SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for exceptionlog
-- ----------------------------
DROP TABLE IF EXISTS `exceptionlog`;
CREATE TABLE `exceptionlog` (
  `Id` char(36) NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Param` text DEFAULT NULL,
  `CreatedBy` char(36) DEFAULT NULL,
  `ModifiedBy` char(36) DEFAULT NULL,
  `CreatedTime` datetime DEFAULT NULL,
  `ModifiedTime` datetime DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for exceptionlog_recycle
-- ----------------------------
DROP TABLE IF EXISTS `exceptionlog_recycle`;
CREATE TABLE `exceptionlog_recycle` (
  `Id` char(36) NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Param` text DEFAULT NULL,
  `CreatedBy` char(36) DEFAULT NULL,
  `ModifiedBy` char(36) DEFAULT NULL,
  `CreatedTime` datetime DEFAULT NULL,
  `ModifiedTime` datetime DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for tracelog
-- ----------------------------
DROP TABLE IF EXISTS `tracelog`;
CREATE TABLE `tracelog` (
  `Id` char(36) NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Param` text DEFAULT NULL,
  `CreatedBy` char(36) DEFAULT NULL,
  `ModifiedBy` char(36) DEFAULT NULL,
  `CreatedTime` datetime DEFAULT NULL,
  `ModifiedTime` datetime DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for tracelog_recycle
-- ----------------------------
DROP TABLE IF EXISTS `tracelog_recycle`;
CREATE TABLE `tracelog_recycle` (
  `Id` char(36) NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Param` text DEFAULT NULL,
  `CreatedBy` char(36) DEFAULT NULL,
  `ModifiedBy` char(36) DEFAULT NULL,
  `CreatedTime` datetime DEFAULT NULL,
  `ModifiedTime` datetime DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;