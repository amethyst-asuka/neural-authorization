
''' <summary>
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `users`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `users` (
'''   `uid` int(11) NOT NULL,
'''   `email` varchar(128) NOT NULL,
'''   `root_device` int(11) NOT NULL COMMENT 'The first device that user register on the platform, this property point to the device_tree table uid.',
'''   PRIMARY KEY (`uid`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' -- Dumping data for table `users`
''' --
''' 
''' LOCK TABLES `users` WRITE;
''' /*!40000 ALTER TABLE `users` DISABLE KEYS */;
''' /*!40000 ALTER TABLE `users` ENABLE KEYS */;
''' UNLOCK TABLES;
''' /*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;
''' 
''' /*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
''' /*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
''' /*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
''' /*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
''' /*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
''' /*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
''' /*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
''' 
''' -- Dump completed on 2016-07-22 21:26:43
''' 
''' </summary>
''' <remarks></remarks>
Public Class users
#Region "Public Property Mapping To Database Fields"
    Public Property uid As Long
    Public Property email As String
    ''' <summary>
    ''' The first device that user register on the platform, this property point to the device_tree table uid.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property root_device As Long
#End Region
End Class
