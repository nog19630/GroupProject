CREATE DATABASE `ede`;

CREATE TABLE `customer` (
  `customerID` bigint NOT NULL AUTO_INCREMENT,
  `customerName` varchar(50) NOT NULL,
  `customerPhone` varchar(15) NOT NULL,
  `customerFax` varchar(15) DEFAULT NULL,
  `customerAddress` varchar(255) DEFAULT NULL,
  `customerPostCode` varchar(16) DEFAULT NULL,
  `customerBusiness` char(1) DEFAULT NULL,
  `customerCreditLimit` int DEFAULT NULL,
  `status` char(1) DEFAULT NULL,
  `customerCreditInfo` char(16) DEFAULT NULL,
  PRIMARY KEY (`customerID`)
);

INSERT INTO customer VALUES ('87654000', 'Samlaq', '11111000', NULL, 'mary1000@gmail.com', NULL, NULL, NULL, NULL, NULL);
INSERT INTO customer VALUES ('87654020', 'Sam', '55205520', NULL, 'Sam1000@gmail.com', NULL, NULL, NULL, NULL, NULL);
INSERT INTO customer VALUES ('87654021', 'ann', '58207410', NULL, 'ann1001@gmail.com', NULL, NULL, NULL, NULL, NULL);
INSERT INTO customer VALUES ('87654022', 'lai', '59637410', NULL, 'lai1002@gmail.com', NULL, NULL, NULL, NULL, NULL);
INSERT INTO customer VALUES ('87654023', 'law', '52014711', NULL, 'law1003@gmail.com', NULL, NULL, NULL, NULL, NULL);
INSERT INTO customer VALUES ('87654024', 'Sat', '96308520', NULL, 'Sat1004@gmail.com', NULL, NULL, NULL, NULL, NULL);
INSERT INTO customer VALUES ('87654025', 'Saay', '74108520', NULL, 'Saay1005@gmail.com', NULL, NULL, NULL, NULL, NULL);

CREATE TABLE `documentfreight` (
  `itemID` bigint NOT NULL AUTO_INCREMENT,
  `name` char(50) NOT NULL,
  `quantity` int NOT NULL,
  `serviceType` varchar(20) NOT NULL,
  `serviceOtherType` varchar(50) DEFAULT NULL,
  `declaredvalue` int DEFAULT NULL,
  `centerID` varchar(10) DEFAULT NULL,
  `shipmentNo` bigint DEFAULT NULL,
  `charge` float DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`itemID`)


);

CREATE TABLE `message` (
  `messageID` bigint NOT NULL,
  `sender` bigint NOT NULL,
  `sendTime` time DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  `messageType` varchar(45) DEFAULT NULL,
  `receiver` bigint NOT NULL,
  PRIMARY KEY (`messageID`),
  KEY `pk_message_sender_idx` (`sender`),
  KEY `pk_message_receiver_idx` (`receiver`)

);

INSERT INTO documentfreight VALUES('1', 'LAIPUIyin', '35', 'Document', '', '554', 'hk01', NULL, '68', 'Cargo handling carefully');
INSERT INTO documentfreight VALUES('3', 'LAIPUIyin', '39', 'Document', '', '164', 'hk02', '123456004', '68', 'Cargo handling carefully');
INSERT INTO documentfreight VALUES('4', 'PUIyin', '9', 'Package express', '', '2', 'jp03', '123456003', '68', 'Cargo handling carefully');
INSERT INTO documentfreight VALUES('6', 'PUIyai', '859', 'Worldmail', '', '86', 'jp02', '123456005', '8', 'Cargo handling carefully');
INSERT INTO documentfreight VALUES('7', 'LAIPUI', '35', 'Document', '', '555', NULL, NULL, '6208', 'Cargo handling carefully');


CREATE TABLE `edeaccount` (
  `edeID` bigint NOT NULL AUTO_INCREMENT,
  `customerID` bigint NOT NULL,
  `emailAddress` varchar(50) NOT NULL,
  `loginAccountName` varchar(16) NOT NULL,
  `loginAccountPw` varchar(16) NOT NULL,
  `emailNotice` char(1) DEFAULT NULL,
  PRIMARY KEY (`edeID`)

  
);

INSERT INTO edeaccount VALUES('12340001', '87654000', '1001@gmail.com', 'root0001', 'root0001', '');
INSERT INTO edeaccount VALUES('12340021', '87654020', 'sam1001@gmail.com', 'root2001', 'root1231', NULL);
INSERT INTO edeaccount VALUES('12340022', '87654021', 'saa1002@gmail.com', 'root2002', 'root1232', NULL);
INSERT INTO edeaccount VALUES('12340023', '87654022', 'sasa1003@gmail.com', 'root2003', 'root1233', NULL);
INSERT INTO edeaccount VALUES('12340024', '87654023', 'qwe1004@gmail.com', 'root2004', 'root1234', NULL);
INSERT INTO edeaccount VALUES('12340025', '87654024', 'asd1005@gmail.com', 'root2005', 'root1235', NULL);
INSERT INTO edeaccount VALUES('12340026', '87654025', 'das1006@gmail.com', 'root2006', 'root1236', NULL);

CREATE TABLE `freight` (
  `itemID` bigint NOT NULL AUTO_INCREMENT,
  `weight` float NOT NULL,
  `length` float NOT NULL,
  `width` float NOT NULL,
  `height` float NOT NULL,
  `value` float DEFAULT NULL,
  PRIMARY KEY (`itemID`)
  
);
INSERT INTO freight VALUES ('4', '34.56', '101.5', '102.5', '103', '52');

CREATE TABLE `invoice` (
  `invoiceID` bigint NOT NULL AUTO_INCREMENT,
  `customerID` bigint NOT NULL,
  `totalDeliveryCost` float NOT NULL,
  `detail` varchar(255) DEFAULT NULL,
  `verification` char(1) DEFAULT NULL,
  `paymentMethod` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`invoiceID`)

 
);

INSERT INTO invoice VALUES('980000001', '87654000', '98764300', 'important client', 'y', 'credit card');
INSERT INTO invoice VALUES('980000002', '87654020', '98764200', 'Cargo is careful and fragile', 'y', 'credit card');
INSERT INTO invoice VALUES('980000003', '87654021', '987641', 'Handle with care', 'y', 'credit card');
INSERT INTO invoice VALUES('980000004', '87654022', '9841', 'Handle with care', 'N', 'credit card');
INSERT INTO invoice VALUES('980000005', '87654023', '900041', 'Handle with care', 'N', 'cash');
INSERT INTO invoice VALUES('980000006', '87654024', '900', 'Handle with care', 'N', 'cash');

CREATE TABLE `operationcenter` (
  `centerID` varchar(10) NOT NULL,
  `district` varchar(50) NOT NULL,
  `hotlineNum` varchar(15) NOT NULL,
  `rent` int NOT NULL,
  `electricity` int DEFAULT NULL,
  PRIMARY KEY (`centerID`)
);

INSERT INTO operaetioncenter VALUES ('hk01', 'Lok Ma Chau', '85265489751', '500', '500');
INSERT INTO operaetioncenter VALUES ('hk02', 'Lo Wu', '85251698745', '500568', '65500');
INSERT INTO operaetioncenter VALUES ('jp01', 'Shibuya', '8151665985', '6800', '650');
INSERT INTO operaetioncenter VALUES ('jp02', 'Shibuya', '8151600985', '800', NULL);
INSERT INTO operaetioncenter VALUES ('jp03', ' Ikebukuro', '8155000005', '800', '700');
INSERT INTO operaetioncenter VALUES ('sh01', 'xinzhuang ', '2151698745', '5068', '600');
INSERT INTO operaetioncenter VALUES ('sh02', 'xinzhuang ', '2151600745', '50628', '6020');
INSERT INTO operaetioncenter VALUES ('sh03', 'hanghainan Railway Station', '2151607445', '520', '600');
INSERT INTO operaetioncenter VALUES ('sh04', 'hanghainan Railway Station', '2156687445', '5330', '65200');

CREATE TABLE `paymentgateway` (
  `gatewayID` bigint NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`gatewayID`)
);

INSERT INTO paymentgateway VALUES ('1900', 'Chau Lok Ma ');
INSERT INTO paymentgateway VALUES ('1901', 'Chau Lok ');
INSERT INTO paymentgateway VALUES ('1902', 'Chau pui ');
INSERT INTO paymentgateway VALUES ('2100', 'Chau yin');
INSERT INTO paymentgateway VALUES ('2101', 'Chau Ma ');
INSERT INTO paymentgateway VALUES ('2105', 'Chau sam');

CREATE TABLE `pickuporder` (
  `orderID` bigint NOT NULL AUTO_INCREMENT,
  `edeID` bigint NOT NULL,
  `pickupDate` date NOT NULL,
  `pickupTime` time NOT NULL,
  PRIMARY KEY (`orderID`)

  
);

INSERT INTO pickuporder VALUES('2018050606', '12340025', '2018-05-06', '06:30:00');
INSERT INTO pickuporder VALUES('2019061609', '12340023', '2019-06-16', '09:00:00');
INSERT INTO pickuporder VALUES('2020061809', '12340022', '2020-06-18', '09:00:00');
INSERT INTO pickuporder VALUES('2021021709', '12340024', '2021-02-17', '09:30:00');
INSERT INTO pickuporder VALUES('2021051703', '12340001', '2021-05-17', '03:00:00');
INSERT INTO pickuporder VALUES('2021061803', '12340021', '2021-06-18', '03:00:00');


CREATE TABLE `shipment` (
  `shipmentNo` bigint NOT NULL AUTO_INCREMENT,
  `sender` bigint NOT NULL,
  `receiver` bigint NOT NULL,
  `centerID` varchar(10) DEFAULT NULL,
  `gatewayID` bigint DEFAULT NULL,
  `date` date NOT NULL,
  `insurance` varchar(32) DEFAULT NULL,
  `commodityCode` varchar(8) DEFAULT NULL,
  `shipmentType` char(1) NOT NULL,
  `status` varchar(10) DEFAULT NULL,
  `invoiceID` bigint DEFAULT NULL,
  PRIMARY KEY (`shipmentNo`)


);

INSERT INTO shipment VALUES ('123456000', '87654000', '87654023', 'hk01', '1900', '2003-03-01', 'AXA', '100001', 'F', 'totransfer', '980000001');
INSERT INTO shipment VALUES ('123456001', '87654021', '87654022', 'hk02', '1900', '2013-03-01', 'AXA', '100002', 'F', 'wait_pay', '980000003');
INSERT INTO shipment VALUES ('123456002', '87654022', '87654020', 'sh03', '1901', '2019-03-11', 'AXA', '100003', 'D', 'wait_pay', '980000004');
INSERT INTO shipment VALUES ('123456003', '87654020', '87654021', 'jp01', '2100', '2020-05-11', 'AXA', '100004', 'F', 'wait_pay', '980000002');
INSERT INTO shipment VALUES ('123456004', '87654020', '87654023', 'jp02', '2101', '2020-06-11', 'AXA', '100005', 'D', 'wait_bill', '980000002');
INSERT INTO shipment VALUES ('123456005', '87654023', '87654025', 'jp03', '2105', '2020-08-11', 'AXA', '100006', 'D', 'wait_bill', '980000005');

CREATE TABLE `staff` (
  `staffID` bigint NOT NULL AUTO_INCREMENT,
  `staffPassword` varchar(45) NOT NULL,
  `dob` date NOT NULL,
  `centerID` varchar(10) DEFAULT NULL,
  `nationalIDNum` varchar(20) NOT NULL,
  `contactPhoneNum` varchar(15) NOT NULL,
  `department` varchar(20) DEFAULT NULL,
  `position` varchar(20) DEFAULT NULL,
  `salary` int DEFAULT NULL,
  `officePhoneNum` int DEFAULT NULL,
  PRIMARY KEY (`staffID`)

);

INSERT INTO staff VALUES ('11301', 'bascef', '2021-05-21', 'hk01', 'e455209(2)', '8528743201', 'Customer Service', 'staff', '62088', '21836954');
INSERT INTO staff VALUES ('11302', '9223052', '2009-03-01', 'hk01', 'e456209(3)', '58743201', 'Customer Service', 'manager', '62050', '51836954');
INSERT INTO staff VALUES ('11336', 'assss', '2008-03-11', 'hk02', 'e480209(3)', '69943201', 'Customer Service', 'staff', '22050', '22002254');
INSERT INTO staff VALUES ('11338', 'ejk', '2018-03-11', 'hk02', '310102054003', '69943201', 'Customer Service', 'IT Officer', '12050', '28902254');
INSERT INTO staff VALUES ('11358', 'lokdi', '2019-03-11', 'sh01', '355681054003', '65820411', 'Transportation', 'staff', '19050', '28902254');
INSERT INTO staff VALUES ('11399', 'qqpods022', '2019-03-11', 'sh02', '358681054003', '65858314', 'Transportation', 'manager', '19050', '23562254');

CREATE TABLE `vehicle` (
  `vehicleID` bigint NOT NULL AUTO_INCREMENT,
  `model` varchar(40) NOT NULL,
  `centerID` varchar(10) NOT NULL,
  `staffID` bigint DEFAULT NULL,
  PRIMARY KEY (`vehicleID`)

  
);

INSERT INTO vehicle VALUES ('2', 'UA-DETRAC', 'hk03', '11302');
INSERT INTO vehicle VALUES ('55', 'UA-DETRAC', 'hk03', '11301');
INSERT INTO vehicle VALUES ('1233', 'SmootASP', 'hk02', '11301');
INSERT INTO vehicle VALUES ('2344', 'SmoothAP', 'hk01', '11399');

ALTER TABLE `documentfreight`
ADD  CONSTRAINT `pk_document_center` FOREIGN KEY (`centerID`) REFERENCES `operationcenter` (`centerID`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD  CONSTRAINT `pk_document_shipment` FOREIGN KEY (`shipmentNo`) REFERENCES `shipment` (`shipmentNo`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `edeaccount`
ADD CONSTRAINT `pk_edeaccount_customerID` FOREIGN KEY (`customerID`) REFERENCES `customer` (`customerID`);

ALTER TABLE `freight`
ADD CONSTRAINT `pk_freight_itemID` FOREIGN KEY (`itemID`) REFERENCES `documentfreight` (`itemID`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `invoice`
ADD CONSTRAINT `pk_invoice_customerID` FOREIGN KEY (`customerID`) REFERENCES `customer` (`customerID`);

ALTER TABLE `pickuporder`
ADD CONSTRAINT `pk_pickuporder_edeID` FOREIGN KEY (`edeID`) REFERENCES `edeaccount` (`edeID`);

ALTER TABLE `shipment`
ADD CONSTRAINT `fk_invoice_invoiceID` FOREIGN KEY (`invoiceID`) REFERENCES `invoice` (`invoiceID`),
ADD  CONSTRAINT `pk_shipment_center` FOREIGN KEY (`centerID`) REFERENCES `operationcenter` (`centerID`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD  CONSTRAINT `pk_shipment_gateway` FOREIGN KEY (`gatewayID`) REFERENCES `paymentgateway` (`gatewayID`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD  CONSTRAINT `pk_shipment_receiver` FOREIGN KEY (`receiver`) REFERENCES `customer` (`customerID`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD  CONSTRAINT `pk_shipment_sender` FOREIGN KEY (`sender`) REFERENCES `customer` (`customerID`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `staff`
ADD CONSTRAINT `pk_staff_centerid` FOREIGN KEY (`centerID`) REFERENCES `operationcenter` (`centerID`);

ALTER TABLE `vehicle`
ADD CONSTRAINT `pk_vehicle_staffID` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffID`);

ALTER TABLE `message`
ADD CONSTRAINT `pk_message_receiver` FOREIGN KEY (`receiver`) REFERENCES `edeaccount` (`edeID`),
ADD CONSTRAINT `pk_message_sender` FOREIGN KEY (`sender`) REFERENCES `staff` (`staffID`);

