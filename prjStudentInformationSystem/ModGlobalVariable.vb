Imports MySql.Data.MySqlClient
Module ModGlobalVariable
    Public conUMTC As New MySqlConnection   'Variable na maggunit sa connection
    Public command As New MySqlCommand      'Variable na maggunit sa mga sql command

    Public strConnection As String          'database credentials holder

    Public servername As String             'localhost
    Public databasename As String           'umtc'
    Public databaseuserid As String         'root'
    Public databasepassword As String       'umtc or depends on the password you set
    Public port As String                   '3306 or 3307
    Public studentphotopath As String
    Public sqlUMTCAdapter As New MySqlDataAdapter
    Public datUMTC As New DataTable
    Public row As Integer
    Public id As Integer
    Public action As String
End Module
