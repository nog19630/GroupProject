CREATE DATABASE `ede`;  

CREATE TABLE `customer` (
  `customerID` char(12) NOT NULL,
  `customerName` varchar(50) NOT NULL,
  `customerPhone` varchar(15) NOT NULL,
  `customerFax` varchar(15) DEFAULT NULL,
  `customerAddress` varchar(50) NOT NULL,
  `customerPostCode` varchar(16) DEFAULT NULL,
  `customerBusiness` char(1) DEFAULT NULL,
  `customerCreditLimit` int DEFAULT NULL,
  `status` char(1) DEFAULT NULL,
  `customerCreditInfo` char(16) DEFAULT NULL,
  PRIMARY KEY (`customerID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `documentfreight` (
  `itemID` char(15) NOT NULL,
  `name` char(50) NOT NULL,
  `quantity` int NOT NULL,
  `serviceType` char(1) NOT NULL,
  `serviceOtherType` varchar(50) DEFAULT NULL,
  `status` varchar(10) DEFAULT NULL,
  `centerID` char(4) DEFAULT NULL,
  `shipmentNo` char(12) DEFAULT NULL,
  `charge` float DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`itemID`),
  KEY `pk_center_id_idx` (`centerID`),
  KEY `pk_shipment_no_idx` (`shipmentNo`),
  CONSTRAINT `pk_center_id` FOREIGN KEY (`centerID`) REFERENCES `operationcenter` (`centerID`),
  CONSTRAINT `pk_freight_id` FOREIGN KEY (`itemID`) REFERENCES `frieght` (`itemID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `pk_shipment_no` FOREIGN KEY (`shipmentNo`) REFERENCES `shipment` (`shipmentNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `edeaccount` (
  `edeID` char(10) NOT NULL,
  `customerID` char(12) NOT NULL,
  `emailAddress` varchar(50) NOT NULL,
  `loginAccountName` varchar(16) NOT NULL,
  `loginAccountPw` varchar(16) NOT NULL,
  `emailNotice` char(1) DEFAULT NULL,
  PRIMARY KEY (`edeID`),
  KEY `pk_edeaccount_customerID_idx` (`customerID`),
  CONSTRAINT `pk_edeaccount_customerID` FOREIGN KEY (`customerID`) REFERENCES `customer` (`customerID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `freight` (
  `itemID` char(15) NOT NULL,
  `weight` float NOT NULL,
  `length` float NOT NULL,
  `width` float NOT NULL,
  `height` float NOT NULL,
  `value` float DEFAULT NULL,
  PRIMARY KEY (`itemID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `invoice` (
  `invoiceID` int NOT NULL,
  `customerID` char(12) NOT NULL,
  `totalDeliveryCost` float NOT NULL,
  `detail` varchar(255) DEFAULT NULL,
  `verification` char(1) DEFAULT NULL,
  `paymentMethod` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`invoiceID`),
  KEY `pk_invoice_customerID_idx` (`customerID`),
  CONSTRAINT `pk_invoice_customerID` FOREIGN KEY (`customerID`) REFERENCES `customer` (`customerID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `operationcenter` (
  `centerID` char(4) NOT NULL,
  `district` varchar(50) NOT NULL,
  `hotlineNum` varchar(15) NOT NULL,
  `rent` int NOT NULL,
  `electricity` int DEFAULT NULL,
  PRIMARY KEY (`centerID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `paymentgateway` (
  `gatewayID` char(4) NOT NULL,
  `name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`gatewayID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `pickuporder` (
  `orderID` int NOT NULL,
  `edeID` char(10) NOT NULL,
  `pickupDate` date NOT NULL,
  `pickupTime` time NOT NULL,
  PRIMARY KEY (`orderID`),
  KEY `pk_pickuporder_edeID_idx` (`edeID`),
  CONSTRAINT `pk_pickuporder_edeID` FOREIGN KEY (`edeID`) REFERENCES `edeaccount` (`edeID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `shipment` (
  `shipmentNo` char(12) NOT NULL,
  `sender` char(45) NOT NULL,
  `receiver` char(45) NOT NULL,
  `centerID` char(4) DEFAULT NULL,
  `gatewayID` char(4) DEFAULT NULL,
  `date` date NOT NULL,
  `insurance` varchar(32) DEFAULT NULL,
  `commodityCode` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`shipmentNo`),
  KEY `pk_sender_idx` (`sender`),
  KEY `pk_receiver_idx` (`receiver`),
  KEY `pk_center_ID_idx` (`centerID`),
  KEY `pk_shipment_centerID_idx` (`centerID`),
  KEY `pk_shipment_gatewayID_idx` (`gatewayID`),
  CONSTRAINT `pk_shipment_centerID` FOREIGN KEY (`centerID`) REFERENCES `operationcenter` (`centerID`),
  CONSTRAINT `pk_shipment_gatewayID` FOREIGN KEY (`gatewayID`) REFERENCES `paymentgateway` (`gatewayID`),
  CONSTRAINT `pk_shipment_receiver` FOREIGN KEY (`receiver`) REFERENCES `customer` (`customerID`),
  CONSTRAINT `pk_shipment_sender` FOREIGN KEY (`sender`) REFERENCES `customer` (`customerID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `staff` (
  `staffID` char(5) NOT NULL,
  `dob` date NOT NULL,
  `centerID` char(4) NOT NULL,
  `nationalIDNum` varchar(20) NOT NULL,
  `contactPhoneNum` varchar(15) NOT NULL,
  `department` varchar(20) DEFAULT NULL,
  `position` varchar(20) DEFAULT NULL,
  `salary` int DEFAULT NULL,
  `officePhoneNum` int DEFAULT NULL,
  PRIMARY KEY (`staffID`),
  KEY `pk_staff_centerID_idx` (`centerID`),
  CONSTRAINT `pk_staff_centerID` FOREIGN KEY (`centerID`) REFERENCES `operationcenter` (`centerID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `vehicle` (
  `vehicleID` char(4) NOT NULL,
  `model` varchar(40) NOT NULL,
  `centerID` char(4) NOT NULL,
  `staffID` char(5) DEFAULT NULL,
  PRIMARY KEY (`vehicleID`),
  KEY `pk_vehicle_centerID_idx` (`centerID`),
  KEY `pk_vehicle_staffID_idx` (`staffID`),
  CONSTRAINT `pk_vehicle_centerID` FOREIGN KEY (`centerID`) REFERENCES `operationcenter` (`centerID`),
  CONSTRAINT `pk_vehicle_staffID` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
