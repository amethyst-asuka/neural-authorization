''' <summary>
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `device_tree`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `device_tree` (
'''   `uid` int(11) NOT NULL AUTO_INCREMENT COMMENT 'integer uid for token query',
'''   `token` char(32) NOT NULL COMMENT 'md5 hash value of the hardward signature info',
'''   `device_name` varchar(128) DEFAULT NULL,
'''   `register_time` datetime NOT NULL,
'''   `note` tinytext,
'''   PRIMARY KEY (`uid`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' -- Dumping data for table `device_tree`
''' --
''' 
''' LOCK TABLES `device_tree` WRITE;
''' /*!40000 ALTER TABLE `device_tree` DISABLE KEYS */;
''' /*!40000 ALTER TABLE `device_tree` ENABLE KEYS */;
''' UNLOCK TABLES;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
Public Class device_tree

    ''' <summary>
    ''' integer uid for token query
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property uid As Long
    ''' <summary>
    ''' md5 hash value of the hardward signature info
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property token As String
    Public Property device_name As String
    Public Property register_time As Date
    Public Property note As String
End Class
