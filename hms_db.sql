/*
Navicat MySQL Data Transfer

Source Server         : localhost
Source Server Version : 50547
Source Host           : localhost:3306
Source Database       : hms_db

Target Server Type    : MYSQL
Target Server Version : 50547
File Encoding         : 65001

Date: 2016-09-09 14:21:44
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for hm_doctor
-- ----------------------------
DROP TABLE IF EXISTS `hm_doctor`;
CREATE TABLE `hm_doctor` (
  `I_Id` int(11) NOT NULL AUTO_INCREMENT,
  `d_Name` varchar(25) DEFAULT NULL,
  `d_Profession` varchar(25) DEFAULT NULL,
  `d_Time` varchar(25) DEFAULT NULL,
  `d_Major` varchar(25) DEFAULT NULL,
  `d_Department` varchar(25) DEFAULT NULL,
  `p_Expert` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`I_Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of hm_doctor
-- ----------------------------
INSERT INTO `hm_doctor` VALUES ('1', 'wang5', '院长', '8:00~18:00', '医学', '外科', '否');
INSERT INTO `hm_doctor` VALUES ('2', 'wang5', '副院长', '8:00~18:00', '医学', '外科', '是');
INSERT INTO `hm_doctor` VALUES ('3', 'uu8', '护士长', '8:00~18:00', '医学', '内科', '是');
INSERT INTO `hm_doctor` VALUES ('4', 'uu1', '护士', '8:00~18:00', '护士', '内科', '否');
INSERT INTO `hm_doctor` VALUES ('5', 'wwww', '护士', '8:00~18:00', '护士', '内科', '否');

-- ----------------------------
-- Table structure for hm_fee
-- ----------------------------
DROP TABLE IF EXISTS `hm_fee`;
CREATE TABLE `hm_fee` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `A` int(11) DEFAULT NULL,
  `B` int(11) DEFAULT NULL,
  `C` int(11) DEFAULT NULL,
  `D` int(11) DEFAULT NULL,
  `E` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of hm_fee
-- ----------------------------

-- ----------------------------
-- Table structure for hm_patient
-- ----------------------------
DROP TABLE IF EXISTS `hm_patient`;
CREATE TABLE `hm_patient` (
  `p_Id` int(11) NOT NULL AUTO_INCREMENT,
  `P_Name` varchar(25) DEFAULT NULL,
  `p_Time` varchar(25) DEFAULT NULL,
  `p_Phone` varchar(25) DEFAULT NULL,
  `p_Note` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`p_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of hm_patient
-- ----------------------------

-- ----------------------------
-- Table structure for hm_recipe
-- ----------------------------
DROP TABLE IF EXISTS `hm_recipe`;
CREATE TABLE `hm_recipe` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `p_Id` int(11) DEFAULT NULL,
  `Reason` varchar(255) DEFAULT NULL,
  `d_Id` int(11) DEFAULT NULL,
  `Prescription` varchar(255) DEFAULT NULL,
  `Phone` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of hm_recipe
-- ----------------------------

-- ----------------------------
-- Table structure for hm_user
-- ----------------------------
DROP TABLE IF EXISTS `hm_user`;
CREATE TABLE `hm_user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `a_User` varchar(10) DEFAULT NULL,
  `a_Password` varchar(10) DEFAULT NULL,
  `a_Name` varchar(10) DEFAULT NULL,
  `a_E_mail` varchar(20) DEFAULT NULL,
  `a_Phone` varchar(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of hm_user
-- ----------------------------
INSERT INTO `hm_user` VALUES ('1', 'admin', 'admin', 'admin', '285984303@qq.com', '18600806360');
INSERT INTO `hm_user` VALUES ('2', '@a_User', '@a_Passwor', '@a_Name', '@a_E_mail', '@a_Phone');
INSERT INTO `hm_user` VALUES ('3', 'eee', 'eee', 'eee', 'eee', 'eee');
INSERT INTO `hm_user` VALUES ('4', '12321', '12312', '13123', '13213', '123213');
INSERT INTO `hm_user` VALUES ('5', 'ddd', 'ddd', 'ddd', 'ddd', 'ddd');
INSERT INTO `hm_user` VALUES ('6', '343', '32432', '23423', '23423', '32432');
