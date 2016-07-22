Imports Microsoft.VisualBasic.Serialization.JSON

''' <summary>
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `neural_tokens`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `neural_tokens` (
'''   `uid` int(11) NOT NULL COMMENT 'integer uid for token query',
'''   `t1` int(11) NOT NULL,
'''   `t2` int(11) NOT NULL,
'''   `t3` int(11) NOT NULL,
'''   `t4` int(11) NOT NULL,
'''   `t5` int(11) NOT NULL,
'''   `key` int(11) NOT NULL COMMENT 'index of the t1 or t2 or t3 or t4 or t5, ann result',
'''   `user` int(11) NOT NULL COMMENT 'user id',
'''   PRIMARY KEY (`uid`),
'''   UNIQUE KEY `uid_UNIQUE` (`uid`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' -- Dumping data for table `neural_tokens`
''' --
''' 
''' LOCK TABLES `neural_tokens` WRITE;
''' /*!40000 ALTER TABLE `neural_tokens` DISABLE KEYS */;
''' /*!40000 ALTER TABLE `neural_tokens` ENABLE KEYS */;
''' UNLOCK TABLES;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
Public Class neural_tokens

    Public Property t1 As Long
    Public Property t2 As Long
    Public Property t3 As Long
    Public Property t4 As Long
    Public Property t5 As Long

    Public Overrides Function ToString() As String
        Return Me.GetJson
    End Function

    Public Function IndexOf(x As Long) As Integer
        If t1 = x Then
            Return 0
        ElseIf t2 = x Then
            Return 1
        ElseIf t3 = x Then
            Return 2
        ElseIf t4 = x Then
            Return 3
        ElseIf t5 = X Then
            Return 4
        Else
            Return -1
        End If
    End Function

    Public Shared Function NewToken() As neural_tokens
        Dim rand As New Random(Now.Millisecond)
        Return New neural_tokens With {
            .t1 = rand.Next(Integer.MaxValue),
            .t2 = rand.Next(Integer.MaxValue),
            .t3 = rand.Next(Integer.MaxValue),
            .t4 = rand.Next(Integer.MaxValue),
            .t5 = rand.Next(Integer.MaxValue)
        }
    End Function
End Class

