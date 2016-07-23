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

    ''' <summary>
    ''' Index值，还需要使用<see cref="Value"/>属性进行转换
    ''' </summary>
    ''' <returns></returns>
    Public Property key As Long

    Default Public Property Value(index As Integer) As Long
        Get
            Select Case index
                Case 0 : Return t1
                Case 1 : Return t2
                Case 2 : Return t3
                Case 3 : Return t4
                Case 4 : Return t5
                Case Else
                    Throw New Exception(index)
            End Select
        End Get
        Set(value As Long)
            Select Case index
                Case 0 : t1 = value
                Case 1 : t2 = value
                Case 2 : t3 = value
                Case 3 : t4 = value
                Case 4 : t5 = value
                Case Else
                    Throw New Exception(index)
            End Select
        End Set
    End Property

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
            .t1 = rand.Next(100),
            .t2 = rand.Next(100),
            .t3 = rand.Next(100),
            .t4 = rand.Next(100),
            .t5 = rand.Next(100)
        }
    End Function
End Class

